using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    DoorColliderControl DoorCollider;
    DoorControl Door;
    //TargetLamps NPCFlight;
    fps fps;
    SunFollow sunFollow;
    LampsPosition lampsPos;
    //AirController Air;
    //LightControl lightControl;
    PointLightControl pointLight;
    TokiColliderControl Toki;
    CharacterController characterControl;
    CharacterRotationControl characterRotControl;
    RaycastTest RayCast;

    GameObject NPC;
    GameObject LightS;

	
    
	void Start ()
    {
        DoorCollider = GetComponent<DoorColliderControl>();
        LightS = GameObject.FindGameObjectWithTag("pointL");
        LightS.GetComponent<LightControl>();
        NPC = GameObject.FindGameObjectWithTag("NPC");
        NPC.GetComponentInChildren<TargetLamps>();
        

    }
	
	
	void Update ()
    {
        if(LightS.GetComponent<LightControl>().Night==false)
        {
            Lightman();
        }
        else
        {
            Lighterman();
        }

	}

    IEnumerator LightmanDeactive()
    {
        yield return new WaitForSeconds(2f);
        NPC.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
    IEnumerator LightermanDeactive()
    {
        yield return new WaitForSeconds(2f);

        NPC.gameObject.transform.GetChild(1).gameObject.SetActive(false);

    }

    private void Lightman()
    {
        NPC.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        if(NPC.GetComponentInChildren<TargetLamps>().HomeCount==true)
        {
            StartCoroutine(LightmanDeactive());
        }

  
    }

    private void Lighterman()
    {
        NPC.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        if (NPC.GetComponentInChildren<TargetLamps>().HomeCount == true)
        {
            StartCoroutine(LightermanDeactive());

        }
    }

}
