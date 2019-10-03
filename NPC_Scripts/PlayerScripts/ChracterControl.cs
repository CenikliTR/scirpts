using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterControl : MonoBehaviour
{
    public int speed = 1;
    CharacterController character;
    Vector3 MoveVector;
    const float gravity= 9.8f;
	
	void Start ()
    {
        character = GetComponent<CharacterController>();
	}
	
	
	void Update ()
    {
        MoveCharacter();

	}

    void MoveCharacter()
    {
        MoveVector = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        MoveVector = transform.TransformDirection(MoveVector);
        
        if (!character.isGrounded)
        {
            MoveVector.y -= Time.deltaTime * gravity;
        }
        character.Move(MoveVector);
    }
}
