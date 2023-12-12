using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public Transform objetivo; // El objeto que la c�mara seguir�

    void Update()
    {
        if (objetivo != null)
        {
            // Actualiza la posici�n de la c�mara para que coincida con la del objetivo
            transform.LookAt(objetivo.position);
        }
    }
}
