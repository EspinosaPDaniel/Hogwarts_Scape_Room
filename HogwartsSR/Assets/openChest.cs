using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class openChest : MonoBehaviour
{
   public GameObject objectToRotate;
   public GameObject objectToHit;
   public AudioSource sound;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == objectToHit){
            objectToRotate.transform.Rotate(new Vector3(0f, 0f, -90f));
            Destroy(gameObject);
            Destroy(objectToHit);
			sound.mute=false;
		    sound.Play();

    }
    }

}
