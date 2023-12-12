using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    //asiganmos variables
    Camera camara;
    Rigidbody rb;

    public GameObject Player;

    public float velocidad = 5f;
    public float velocidadRotacion = 120.0f;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Entradas del teclado
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        if (Mathf.Abs(inputHorizontal) > 0.1f || Mathf.Abs(inputVertical) > 0.1f)
        {
            Player.GetComponent<Animator>().Play("Walk");

            // Calcular la rotación basada en las entradas de los controles
            Vector3 rotacion = new Vector3(0, inputHorizontal * velocidadRotacion * Time.deltaTime, 0);
            transform.Rotate(rotacion);

            // Calcular el movimiento basado en la rotación actual
            Vector3 movimiento = transform.forward * inputVertical * velocidad * Time.deltaTime;
            transform.Translate(movimiento, Space.World);
        }
        else
        {
            Player.GetComponent<Animator>().Play("Idle01");
        }

    }
}