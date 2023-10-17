using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public Image HPBar;
    public float Health;
    public float MaxHealth;
    public string LevelName;
    void Start()
    {
        MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        HPBar.fillAmount = Health / MaxHealth;
        if(Health <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        SceneManager.LoadScene(LevelName);
    }
    public void TakeDamage(float damage)
    {
        Health -= damage;
    }
}
