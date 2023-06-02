using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaketeleport : MonoBehaviour
{
    public Transform[] teleportLocations; // Array con las tres ubicaciones de teletransportación
    private int currentIndex = 0; // Índice actual de la ubicación de teletransportación
    public float teleportDelay = 15f; // Tiempo en segundos entre cada teletransportación

    private float timer = 0f; // Temporizador para realizar el teletransporte

    public int contadorColisiones = 0; //Inicializacion de las colisiones
    public int colisionesNecesarias = 3; //Colisiones necesarias

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
        // Comprobar si la colisión es con la esfera
        if (collision.gameObject.CompareTag("Sphere"))
        {
            contadorColisiones++;

            // Comprobar si se alcanzó el número necesario de colisiones
            if (contadorColisiones >= colisionesNecesarias)
            {
                // Desaparecer el objeto
                Destroy(gameObject);
            }
        }
    }
}










