using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotationControl : MonoBehaviour
{
    public float Sensitivy = 3;
    public float RotationX = 0;
    public float RotationY=0;
    	
	void Update ()
    {
        RotationY += Sensitivy * Input.GetAxis("Mouse Y")*-1;
        RotationX += Sensitivy * Input.GetAxis("Mouse X");
        RotationY = Mathf.Clamp(RotationY, -100, +100);
        transform.eulerAngles=(new Vector3(RotationY,RotationX,0));
	}
}
