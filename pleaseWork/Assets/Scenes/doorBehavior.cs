using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBehavior : MonoBehaviour
{
    public playerMovement player;
    public BoxCollider2D box;
    public SpriteRenderer spriteR;
    //public Sprite closedDoor;

    void Update()
    {
        if(player.hasKey == true)
        {
            box.enabled = false;
            spriteR.enabled = false;
            //spriteR.sprite = closedDoor;
        }
    }
}
