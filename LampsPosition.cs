using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampsPosition : MonoBehaviour
{
    public GameObject Lights;
    public int Child;

    public List<Vector3> Vectors;
    void Start()
    {

       Lights = GameObject.FindGameObjectWithTag("Lamps");
           
  
        Child = Lights.transform.childCount;
        Debug.Log(Child);
        for (int i = 0; i < Child; i++)
        {
            Vectors.Add(new Vector3(Lights.transform.GetChild(i).position.x, 0, Lights.transform.GetChild(i).position.z));
        }



    }
	

}
