using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform reswpawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = reswpawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }

}
