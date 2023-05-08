using UnityEngine;
using System.Collections;
 
public class DoorScript : MonoBehaviour {
 
    public static bool doorKey;
    public bool open;
    public bool close;

    void OnMouseDown()
    {
        if (close)
        {
            if (doorKey)
                {
                    
                        open = true;
                        close = false;
                    
                }
            }
            else
            {
                
                    close = true;
                    open = false;
                
            }
        }
 
    void Update(){
        if (open)
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
        else
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
    }
}