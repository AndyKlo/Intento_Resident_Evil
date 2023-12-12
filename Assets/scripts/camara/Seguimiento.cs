using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public Transform objetivo; // El objeto que la cámara seguirá

    void Update()
    {
        if (objetivo != null)
        {
            // Actualiza la posición de la cámara para que coincida con la del objetivo
            transform.LookAt(objetivo.position);
        }
    }
}
