using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public bool Night = false;
    public bool Day = false;
    public GameObject Sky;
    public GameObject Lightman;
    public GameObject Lighterman;

    public float insenity;
    public float deger;
	void Start ()
    {
        Sky = GameObject.FindGameObjectWithTag("Sky");
        //Lightman = GameObject.FindGameObjectWithTag("Lightman");
        //Lighterman = GameObject.FindGameObjectWithTag("Lighterman");
  
	}


    void Update ()
    {
        Light();
        
	}
    void Light()
    {
        if (Night == false)
        {
                       
            deger = Mathf.Lerp(insenity, 1f, 0.5f * Time.deltaTime);
            insenity = deger;
            Sky.GetComponentInChildren<Light>().intensity = deger;

        }
        else
        {
            deger = Mathf.Lerp(insenity, 0f, 0.5f * Time.deltaTime);
            insenity = deger;
            Sky.GetComponentInChildren<Light>().intensity = deger;
        }

    }
}
