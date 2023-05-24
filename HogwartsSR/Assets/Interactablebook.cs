using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


[RequireComponent( typeof( Interactable ) )]

public class Interactablebook : MonoBehaviour{


 public Vector3 openMove;
 public Transform ObjectToMove;



    // Start is called before the first frame update
    void Start()
    {
        // update the current state of door
        UpdateDoorState();
    }

    void ToggleDoor() {

    
            OpenDoor();
       
    }
    void OpenDoor()
    {
    // set isOpen and call to update the actual door in the scene via
    // the UpdateDoorState() function
  
    UpdateDoorState();
    }
    void UpdateDoorState()
    {
    // here we adjust the rotation of the door so that it is physically
    // open or closed
   
          ObjectToMove.localPosition = openMove;
    
    }


    // Update is called once per frame
     // Called every Update() while a Hand is hovering over this object
    private void HandHoverUpdate(Hand hand)
        {
            SteamVR_Input_Sources handType = SteamVR_Input_Sources.Any;
        if (SteamVR_Input.GetStateDown("GrabPinch", handType))
        {
        ToggleDoor();
        }
        }

}
