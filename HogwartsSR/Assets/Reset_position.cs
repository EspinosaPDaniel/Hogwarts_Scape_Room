using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_position : MonoBehaviour
{
 private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fall_detector"))
        {
            ResetObjectPosition();
        }
    }

    void ResetObjectPosition()
    {
        transform.position = initialPosition;
        // Opcionalmente, puedes reiniciar la velocidad, rotación u otros valores del objeto aquí.
    }
}
