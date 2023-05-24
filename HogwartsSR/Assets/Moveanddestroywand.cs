using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveanddestroywand : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform nuevaPosicion;
    public Transform nuevaPosicion2;

     public GameObject objetoAMover;
     public GameObject objetoAMover2;
     public GameObject objectToDestroy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wand_Angel"))
        {
            objetoAMover.transform.position = nuevaPosicion.position;
            objetoAMover2.transform.position = nuevaPosicion2.position;
        }

            if (other.gameObject == objectToDestroy)
        {
            Destroy(objectToDestroy);
        }
    }
}


