using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy_hrrcx : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject objectToDestroy;
   private void OnTriggerEnter(Collider other)
    {

         if (other.gameObject == objectToDestroy)
        {
            Destroy(objectToDestroy);
            SceneManager.LoadScene("MenuFinal");
        }

    }
}
