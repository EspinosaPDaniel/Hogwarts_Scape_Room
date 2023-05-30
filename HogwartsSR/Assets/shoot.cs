using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spell;
    public Transform spawnPoint;
    public float shotForce = 1000;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;
    private SteamVR_Input_Sources inputSource;
	private SteamVR_Action_Boolean buttonAction;
    void Awake()
    {
        inputSource = SteamVR_Input_Sources.RightHand;
	   buttonAction = SteamVR_Actions.default_SnapTurnLeft;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            //if(buttonAction.GetLastStateDown(inputSource))
            if(Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("shoot");
                if(Time.time>shotRateTime){
                GameObject newSpell;
                newSpell=Instantiate(spell, spawnPoint.position,Quaternion.Euler(spawnPoint.rotation.x,spawnPoint.rotation.y+90f,spawnPoint.rotation.z));
                newSpell.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);
                shotRateTime=Time.time+shotRate;
                Destroy(newSpell,2);
            }
            }
    
    }
}
