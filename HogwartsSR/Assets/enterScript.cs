using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enterScript : MonoBehaviour
{
public GameObject player;
  private void OnTriggerEnter(Collider other){


        if (other.CompareTag("Player")){
		player.SetActive(false);
        SceneManager.LoadScene("ENTRADA");
        }
     }
}
