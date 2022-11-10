using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlatter : MonoBehaviour
{
    private float yrotation = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yrotation * Time.deltaTime, 0);
    }
}
