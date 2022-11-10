using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreKeep : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI scoretext;

    void Start()
    {
        points = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        scoretext.text = points.ToString("F0");
    }
}
