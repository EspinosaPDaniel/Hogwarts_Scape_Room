using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int collisionCountThreshold = 3; // Numero de colisiones requeridas antes de destruir el objeto

    public int collisionCount = 0; // Contador de colisiones

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == GameObject.Find("Sphere(Clone)"))
        {
            collisionCount++;
            Debug.Log(collisionCount);

            if (collisionCount >= collisionCountThreshold)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
    }
}
