using UnityEngine;
using System.Collections;
 
[RequireComponent(typeof(AudioSource))]
public class Book : MonoBehaviour {
    public GameObject Cofre;
    public GameObject Cofre2;
    public GameObject Libro;
    public GameObject Modelo;

    AudioSource sound;

void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

private void Start()
    {
        Libro.gameObject.SetActive(false);
        Cofre2.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.name == "RanuraLibro")
        {
            Destroy(colision.gameObject);
            Destroy(Modelo.gameObject);
            Libro.gameObject.SetActive(true);
            Cofre2.gameObject.SetActive(true);
            Destroy(Cofre.gameObject);
            sound.Play();
        }
    }
}