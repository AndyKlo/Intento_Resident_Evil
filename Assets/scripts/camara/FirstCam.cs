using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCam : MonoBehaviour
{
    public Transform Player;
    public Camera activCam1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activCam1.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activCam1.enabled = false;
        }
    }
    void Update()
    {
        
    }
}
