using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dumbledore : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform nuevaPosicion;

     public GameObject objetoAMover;
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cup"))
        
            objetoAMover.transform.position = nuevaPosicion.position;

}
}


