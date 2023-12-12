using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    
    public Light luz;
    public float velocidadParpadeo = 5.0f;
    public float intensidadMinima = 0.5f;
    public float intensidadMaxima = 1.5f;

    void Start()
    {
        // Asegúrate de asignar la luz en el Inspector de Unity
        if (luz == null)
        {
            luz = GetComponent<Light>();
        }

        // Inicia el parpadeo de la luz
        InvokeRepeating("CambiarIntensidadLuz", 0.0f, 1.0f / velocidadParpadeo);
    }

    void CambiarIntensidadLuz()
    {
        // Cambia la intensidad de la luz entre los valores mínimo y máximo
        luz.intensity = Random.Range(intensidadMinima, intensidadMaxima);
    }
}

