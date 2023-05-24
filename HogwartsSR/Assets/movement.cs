using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
/*
 public GameObject objetoADestruir;
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(objetoADestruir);
        }
    }

    */

     public Transform nuevaPosicion;
     public GameObject objetoAMover;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objetoAMover.transform.position = nuevaPosicion.position;
        }
    }
    



}
