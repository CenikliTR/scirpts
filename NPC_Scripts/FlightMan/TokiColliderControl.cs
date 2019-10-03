using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokiColliderControl : MonoBehaviour
{
    BoxCollider collider;
    void Start()
    {
        collider = GetComponent<BoxCollider>();   
    }
    private void OnCollisionStay(Collision collision)
    
    {
        if (collision.gameObject.tag=="Lightman" && collision.gameObject.tag == "Lighterman")
        {
            collider.isTrigger = true;
        }
        else
        {
            collider.isTrigger = false;
        }
    }

}
