using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Action_Vector2 input;
    public float speed;
    private CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x,0,input.axis.y));
       characterController.Move(speed*Time.deltaTime*Vector3.ProjectOnPlane(direction,Vector3.up)-new Vector3(0,9.81f,0)*Time.deltaTime);
    }
}
