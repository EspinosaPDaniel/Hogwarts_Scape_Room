using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class wandController : MonoBehaviour
{
	public GameObject wand;
private SteamVR_Input_Sources inputSource;
private SteamVR_Action_Boolean buttonAction;

    // Start is called before the first frame update
    void Awake()
    {
        inputSource = SteamVR_Input_Sources.LeftHand;
	   buttonAction = SteamVR_Actions.default_Teleport;
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonAction.GetLastStateDown(inputSource))
		{
		wand.SetActive(!wand.activeSelf);
		}
    }
}
