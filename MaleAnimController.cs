using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MaleAnimController : MonoBehaviour {

    NavMeshAgent navMesh;
    Animator anime;
	void Start ()
    {
        navMesh = GetComponent<NavMeshAgent>();
        anime = GetComponent<Animator>();
	}
	
	
	void Update ()
    {
        anime.SetFloat("PlayerVelocity", navMesh.velocity.magnitude);
	}
}
