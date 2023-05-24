using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportSnake : MonoBehaviour
{
    public Transform[] teleportLocations; // Array con las tres ubicaciones de teletransportación
    private int currentIndex = 0; // Índice actual de la ubicación de teletransportación
    public float teleportDelay = 25f; // Tiempo en segundos entre cada teletransportación

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
        // Teletransportar el objeto a la ubicación actual y luego avanzar al siguiente índice
        transform.position = teleportLocations[currentIndex].position;
        currentIndex = (currentIndex + 1) % teleportLocations.Length;
    }
}










