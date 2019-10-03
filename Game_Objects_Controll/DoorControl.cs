using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    public GameObject door;
    public float OpenAngle;
    public bool IsLocked = false;

    public bool IsOpen = false;
    Quaternion StartRot;
    SphereCollider Sphere;
   
	void Start ()
    {
        Sphere = GetComponentInChildren<SphereCollider>();
        StartRot = door.transform.rotation;
       
	}



	void Update ()
    {
        Quaternion CurrentRot = transform.rotation;
        Quaternion newRot = Quaternion.Euler(transform.eulerAngles.x, OpenAngle, transform.eulerAngles.z);

        if (IsOpen)
        {
            transform.rotation = Quaternion.Lerp(CurrentRot, newRot, 0.2f);

        }
        else
        {
            transform.rotation = Quaternion.Lerp(CurrentRot, StartRot, 0.1f);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Lightman")
        {
            Sphere.isTrigger = true;
            IsOpen = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag=="Lightman")
        {
            Sphere.isTrigger = false;
            IsOpen = false;
        }
    }
   
}
