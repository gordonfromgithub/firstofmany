using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform[] Waypoints;
    public int target;
    public float speed;
    public HP Health;
    public float damage;
    void Start()
    {
        target = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != Waypoints[target].position)
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[target].position, speed * Time.deltaTime);
        }
        else
        {
            target = (target + 1) % Waypoints.Length;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Health.TakeDamage(damage);
        }
    }
}
