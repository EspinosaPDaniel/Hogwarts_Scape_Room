using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class demoBehaviour : MonoBehaviour {
	Transform pyvaoq1 = null;
	Animator an;
	private bool open=false;
	private SteamVR_Input_Sources inputSource;
	private SteamVR_Input_Sources inputSource1;
	private SteamVR_Action_Boolean buttonAction;
	public GameObject player;
	public float distance=2.0f;


	// Use this for initialization
	void Start () {
		pyvaoq1 = transform.GetChild(1);
		an = GetComponent<Animator>();
	}
	void Awake()
    {
        inputSource = SteamVR_Input_Sources.RightHand;
	   buttonAction = SteamVR_Actions.default_GrabPinch;
	   inputSource1 = SteamVR_Input_Sources.LeftHand;

    }
	
	// Update is called once per frame
	void Update ()
	{
		if(Vector3.Distance(transform.position, player.transform.position)<=distance){
		if(buttonAction.GetLastStateDown(inputSource)||buttonAction.GetLastStateDown(inputSource1)) {
		if(!open){
		pyvaoq1.localPosition = pyvaoq1.localPosition + new Vector3 (0f, 0f, +0.02f);
		if(pyvaoq1.localPosition== new Vector3(0f,0.22f,0.70f))
		{
			open=true;
		}
		}
		else{
		pyvaoq1.localPosition = pyvaoq1.localPosition + new Vector3 (0f, 0f, -0.02f);
		if(pyvaoq1.localPosition== new Vector3 (0f,0.22f,0.30f))
		{
			open=false;
		}
		}
		}
	}
	}
		
}
