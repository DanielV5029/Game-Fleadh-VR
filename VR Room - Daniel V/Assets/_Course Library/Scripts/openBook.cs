using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBook : MonoBehaviour
{
    public GameObject cover;
    public HingeJoint myHinge;
    void Start()
    {
        var myHinge = cover.GetComponent<HingeJoint>();

        myHinge.useMotor = false;
    }

    // Update is called once per frame
    public void open()
    {
        myHinge.useMotor = true;
    }
}
