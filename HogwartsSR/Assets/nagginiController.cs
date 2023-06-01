using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nagginiController : MonoBehaviour
{
    public int collisionCountThreshold = 3; // Número de colisiones requeridas antes de destruir el objeto

    private int collisionCount = 0; // Contador de colisiones

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
