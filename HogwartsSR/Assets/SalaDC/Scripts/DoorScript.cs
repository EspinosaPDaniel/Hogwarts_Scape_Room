using UnityEngine;
using System.Collections;
 
[RequireComponent(typeof(AudioSource))]
public class DoorScript : MonoBehaviour {
 
    public static bool doorKey;
    public bool open;
    public bool close;

    AudioSource sound;

    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.name == "Llave"){
            sound.Play();
            Destroy(colision.gameObject);
            doorKey = true;
            function();
        }
        
    }

    void function(){
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
    }

    void OnMouseDown(){
        function();
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