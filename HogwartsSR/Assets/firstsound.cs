using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstsound : MonoBehaviour
{
     public AudioClip sonidoColision;

    private AudioSource audioSource;

    public GameObject objecttodestroy;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("key"))
        {
            Debug.Log("Hola");
            ReproducirSonido();
            Destroy(objecttodestroy);
        }

        Debug.Log("Si se produce colision");
    }

    private void ReproducirSonido()
    {
        audioSource.PlayOneShot(sonidoColision);
    }
}
