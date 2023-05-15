using UnityEngine;
using System.Collections;
 
public class Book : MonoBehaviour {
    public GameObject Cofre;
    public GameObject Cofre2;
    public GameObject Libro;

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
            Destroy(this.gameObject);
            Libro.gameObject.SetActive(true);
            Cofre2.gameObject.SetActive(true);
            Destroy(Cofre.gameObject);
        }
    }
}