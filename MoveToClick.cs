using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToClick : MonoBehaviour
{
    NavMeshAgent nav;

	void Start ()
    {
        nav = GetComponent<NavMeshAgent>();

	}
	

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))

        {
            MoveTo();

        }
		 
	}

    private void MoveTo()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) 
        {
            nav.SetDestination(hit.point);
        }
    }
    
}
