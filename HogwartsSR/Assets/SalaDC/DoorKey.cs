using UnityEngine;
using System.Collections;
 
public class DoorKey : MonoBehaviour {
 
    void OnMouseDown()
    {
        HaveKey();
    }
 
    void HaveKey()
    {
        DoorScript.doorKey = true;
        Destroy(this.gameObject);
    }
}