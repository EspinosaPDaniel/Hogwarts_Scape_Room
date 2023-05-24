using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationZone : MonoBehaviour
{
  public Transform teleportTarget; // La posición a la que deseas teletransportarte

    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto que atraviesa la zona de teletransporte es el jugador
        if (other.CompareTag("Player"))
        {
            // Teletransporta al jugador a la nueva posición
            other.transform.position = teleportTarget.position;
        }
    }
}
