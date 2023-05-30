using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationZone : MonoBehaviour
{
  public Transform teleportTarget; // La posición a la que deseas teletransportarte
  public int prueba=0;


    public GameObject jugador;

    private void OnTriggerEnter(Collider other)
    {

        prueba=1;
        // Comprueba si el objeto que atraviesa la zona de teletransporte es el jugador
        if (other.CompareTag("Player"))
        {
            Debug.Log(other.name);
            prueba=10;
            Debug.Log("Prueba cambiado");
            // Teletransporta al jugador a la nueva posición

            Debug.Log(teleportTarget.position);
            //jugador.transform.position = teleportTarget.position;
            //other.transform.position = teleportTarget.position;
            other.GetComponent<Transform>().position = teleportTarget.position;
            Debug.Log("Se ha producido el transporte");
        }
    }


}
