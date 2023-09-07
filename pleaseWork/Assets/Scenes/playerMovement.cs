using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
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
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dir.x * speed, dir.y * speed);
    }
}
