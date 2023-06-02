using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaketeleport : MonoBehaviour
{
    public Transform[] teleportLocations; // Array con las tres ubicaciones de teletransportaci�n
    private int currentIndex = 0; // �ndice actual de la ubicaci�n de teletransportaci�n
    public float teleportDelay = 15f; // Tiempo en segundos entre cada teletransportaci�n

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
        // Teletransportar el objeto a la ubicaci�n actual y luego avanzar al siguiente �ndice
        transform.position = teleportLocations[currentIndex].position;
        currentIndex = (currentIndex + 1) % teleportLocations.Length;
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Comprobar si la colisi�n es con la esfera
        if (collision.gameObject.CompareTag("Sphere"))
        {
            contadorColisiones++;

            // Comprobar si se alcanz� el n�mero necesario de colisiones
            if (contadorColisiones >= colisionesNecesarias)
            {
                // Desaparecer el objeto
                Destroy(gameObject);
            }
        }
    }
}










