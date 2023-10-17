using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public GameObject myText;
    public UnityEvent ToRun;
    public bool InRange = false;
    public string LevelName;
    void Start()
    {
        myText.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Submit") && InRange)
        {
            ToRun.Invoke();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("We enter the trigger");
            myText.SetActive(true);
            InRange = true;
            SceneManager.LoadScene(LevelName);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("We exit the trigger");
            myText.SetActive(false);
            InRange = false;
        }
    }
}
