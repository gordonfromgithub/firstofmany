using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        { playerMovement play = other.gameObject.GetComponent<playerMovement>();
            play.hasKey = true;
            Destroy(gameObject);
        }
    }
}
