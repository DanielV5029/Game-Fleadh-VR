using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hoopTrigger : MonoBehaviour
{
    public GameObject canvas;
    public float timeLeft = 1f;
    public bool isTriggered = false;
    public AudioSource playerAudioSource;
    public scoreKeep sk;

    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Score");
        canvas.SetActive(true);
        isTriggered = true;
        playerAudioSource.Play();
        sk.points++;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Destroyed"); 
        Destroy(other);
    }
    void TimerDown()
    {
        if (isTriggered == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0f)
            {
                canvas.SetActive(false);
                timeLeft = 1f;
                isTriggered = false;
            }
        }
    }

    void Update()
    {
        TimerDown();
    }
}
