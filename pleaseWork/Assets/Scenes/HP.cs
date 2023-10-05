using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Image HPBar;
    public float Health;
    float MaxHealth;
    void Start()
    {
        MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        HPBar.fillAmount = Health / MaxHealth;
    }

    public void Death()
    {
        Debug.Log("I died");
    }
    public void TakeDamage(float damage)
    {
        Health -= damage;
    }
}
