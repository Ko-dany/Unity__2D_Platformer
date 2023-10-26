using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] private Text remainingChicken;

    private AudioSource finishSound;
    private bool levelCompleted = false;
    
    private void Start()
    {
        remainingChicken.enabled = false;
        finishSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int numberOfChickens = GameObject.FindGameObjectsWithTag("Banana").Length;
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            if(numberOfChickens == 0)
            {
                finishSound.Play();
                Invoke("CompleteLevel", 2f);
                levelCompleted = true;
            } else
            {
                remainingChicken.enabled = true;
                remainingChicken.text = $"There are ({GameObject.FindGameObjectsWithTag("Banana").Length}) chickens remaining";
                Invoke("DisableText", 3f);
            }
            
        }
    }
    private void DisableText()
    {
        remainingChicken.enabled = false;
    }
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
