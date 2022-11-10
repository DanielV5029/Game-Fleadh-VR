using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public TextMeshProUGUI timerText;
    public bool isTriggered = false;
    public GameObject canvas;


    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);

        gameOver();

    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay <= 0)
        {
            isTriggered = true;
            timeToDisplay = 0;
        }
        else if (timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = $"{minutes}:{seconds:00}";
    }

    void gameOver()
    {
        if (isTriggered == true)
        {
            canvas.SetActive(true);
        }
    }

}
