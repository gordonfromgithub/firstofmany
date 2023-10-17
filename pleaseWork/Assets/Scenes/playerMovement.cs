using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer Sprite;
    private Vector2 dir;
    public bool hasKey = true;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        dir = new Vector2(x, y).normalized; //where we move
        //transform.Translate(direction * Time.deltaTime * speed); //how we move

        if (x > 0 || x < 0)
        {
            anim.SetTrigger("SideWays");
            ClearWalkCycle();
            anim.SetBool("Side", true);
        }

        else if (y > 0)
        {
            ClearWalkCycle();
            anim.SetBool("Up", true);
        }

        else if (y < 0)
        {
            ClearWalkCycle();
            anim.SetBool("Down", true);
        }

        else if (x == 0 && y == 0)
        {
            ClearWalkCycle();
            anim.SetBool("Idle", true);
        }
        
        if (x < 0)
        {
            Sprite.flipX = true;
        }
        if (x > 0)
        {
            Sprite.flipX = false;
        }
    }

    public void ClearWalkCycle()
    {
        anim.SetBool("Down", false);
        anim.SetBool("Idle", false);
        anim.SetBool("Up", false);
        anim.SetBool("Side", false);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dir.x * speed, dir.y * speed);
    }
}
