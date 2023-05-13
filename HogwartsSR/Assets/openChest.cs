using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{
   public GameObject objectToRotate;
   public GameObject objectToHit;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == objectToHit){
            objectToRotate.transform.Rotate(new Vector3(0f, 0f, -90f));
            Destroy(gameObject);
            Destroy(objectToHit);

    }
    }

}
