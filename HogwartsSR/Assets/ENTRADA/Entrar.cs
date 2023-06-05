using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrar : MonoBehaviour
{
    public int collisionCountThreshold = 1; // Numero de colisiones requeridas antes de destruir el objeto

    public int collisionCount = 0; // Contador de colisiones

    private void OnCollisionEnter(Collision collision)
    {
        // Comprueba si la colisión involucra un Character Controller y un Box Collider

        Debug.Log("Se produce colision");
        if (collision.collider.GetComponent<CharacterController>() != null && collision.collider.GetComponent<BoxCollider>() != null && collision.collider.name == "Puerta")
        {
            // Incrementa el contador de colisiones
            collisionCount++;
            if (collisionCount >= collisionCountThreshold)
            {
                StartCoroutine(DelayedAction());
                SceneManager.LoadScene("SalaComun");
            }
        }

    }

     private void OnTriggerEnter(Collider other){

        SceneManager.LoadScene("SalaComun");
     }

    private IEnumerator DelayedAction()
    {
        yield return new WaitForSecondsRealtime(2f);

        // Acción a realizar después del retraso
        Debug.Log("Delayed action executed!");
    }
}

