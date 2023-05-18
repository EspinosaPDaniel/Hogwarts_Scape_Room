using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportSnake : MonoBehaviour
{
    public Transform[] teleportLocations; // Array con las tres ubicaciones de teletransportaci�n
    private int currentIndex = 0; // �ndice actual de la ubicaci�n de teletransportaci�n
    public float teleportDelay = 25f; // Tiempo en segundos entre cada teletransportaci�n

    private float timer = 0f; // Temporizador para realizar el teletransporte

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
}










