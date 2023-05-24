using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Personaje") && collision.gameObject.CompareTag("Puerta"))
        {
            SceneManager.LoadScene("SalaComun");
        }
    }
}