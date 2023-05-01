using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linternaController : MonoBehaviour
{
    public Light light;
    public Light light2;
    // Start is called before the first frame update
   void Start()
    {
        // Apagamos la linterna al inicio
        light.enabled = false;
        light2.enabled = false;
    }
    
    void Update()
    {
        // Si se presiona la tecla F, cambiamos el estado de la linterna
        if (Input.GetKeyDown(KeyCode.F))
        {
            light.enabled = !light.enabled;
            light2.enabled = !light2.enabled;
        }
    }
}
