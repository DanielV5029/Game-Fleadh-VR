using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceSound : MonoBehaviour
{   

    public Rigidbody rb;
    public AudioSource hitsound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        float volumeball = rb.velocity.magnitude;
        if (volumeball > 20) volumeball = 20;
        hitsound.PlayOneShot(hitsound.clip, volumeball / 20);
    }
}
