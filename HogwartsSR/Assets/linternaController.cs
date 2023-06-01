using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class linternaController : MonoBehaviour
{
    public Light light;
    public Light light2;
	private SteamVR_Input_Sources inputSource;
	private SteamVR_Action_Boolean buttonAction;
    // Start is called before the first frame update
   void Start()
    {
        // Apagamos la linterna al inicio
        light.enabled = false;
        light2.enabled = false;
    }
	void Awake()
    {
        inputSource = SteamVR_Input_Sources.RightHand;
	   buttonAction = SteamVR_Actions.default_SnapTurnRight;
    }
    
    void Update()
    {
        // Si se presiona la tecla F, cambiamos el estado de la linterna
        if(Input.GetKeyDown(KeyCode.F)||buttonAction.GetLastStateDown(inputSource))
        {
            light.enabled = !light.enabled;
            light2.enabled = !light2.enabled;
        }
    }
}
