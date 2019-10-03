using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightControl : MonoBehaviour
{

    private void Off()
    {
        this.GetComponentInChildren<Light>().enabled = false;
        this.GetComponent<SphereCollider>().enabled = false;
      
    }
    private void On()
    {
        this.gameObject.SetActive(true);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lightman")
        {
            Off();
        }
        if (other.gameObject.tag == "Lighterman")
        {
            On();
        }


    }


}
