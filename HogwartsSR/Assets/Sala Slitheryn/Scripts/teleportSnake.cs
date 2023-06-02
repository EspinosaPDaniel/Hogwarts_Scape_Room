using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaketeleport : MonoBehaviour
{
    public Transform[] teleportLocations; // Array con las tres ubicaciones de teletransportación
    private int currentIndex = 0; // Índice actual de la ubicación de teletransportación
    public float teleportDelay = 15f; // Tiempo en segundos entre cada teletransportación

    private float timer = 0f; // Temporizador para realizar el teletransporte

    public int collisionCountThreshold = 3; // Número de colisiones requeridas antes de destruir el objeto

    private int collisionCount = 0; // Contador de colisiones

    private void Update()
    {
        timer += Time.deltaTime;

        // Comprobar si ha pasado el tiempo suficiente para teletransportar el objeto
        if (timer >= teleportDelay)
        {
            Teleport();
            timer = 0f;
        }
    }

    private void Teleport()
    {
        // Teletransportar el objeto a la ubicación actual y luego avanzar al siguiente índice
        transform.position = teleportLocations[currentIndex].position;
        currentIndex = (currentIndex + 1) % teleportLocations.Length;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == GameObject.Find("Sphere(Clone)"))
        {
            collisionCount++;
            Debug.Log(collisionCount);

            if (collisionCount >= collisionCountThreshold)
            {
                Destroy(gameObject);
            }
        }
    }
}










