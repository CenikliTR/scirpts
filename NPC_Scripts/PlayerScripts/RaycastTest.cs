using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{

    public GameObject Lamps;


    void Start()
    {
        Lamps = GameObject.FindGameObjectWithTag("pointL");
        
        
    }



    void Update ()
    {

      
            Raycast();
        

	}

    private void Raycast()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 30, Color.red);
        if (Physics.Raycast(transform.position, transform.forward,out hit, 30))
        {
            Debug.Log("obje"+hit.transform.name);
            if(hit.transform.tag=="Door")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (hit.transform.GetComponent<DoorControl>().IsOpen == false)
                    {
                        hit.transform.GetComponent<DoorControl>().IsOpen = true;

                    }
                    else
                    {
                        hit.transform.GetComponent<DoorControl>().IsOpen = false;
                    }
                }
            }
            
        }
        
    }
}
