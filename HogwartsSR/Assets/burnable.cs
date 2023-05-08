using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnable : MonoBehaviour
{
    public GameObject fireObject;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == fireObject)
        {
            Destroy(gameObject);
        }
    }
}
