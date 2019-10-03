using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirController : MonoBehaviour
{
    public float time;
    public int hour;
    public int minute;
    public int second;
    public Text clock;
    GameObject Light;

    void Start()
    {
        Light = GameObject.FindGameObjectWithTag("pointL");
        Light.GetComponent<LightControl>();

    }



    void Update ()
    {
        Seconds();
        Minute();
        Hour();
        clock.text = " "+hour + ":" + minute + ":" + second;

	}

    void Seconds()
    {
        time += Time.deltaTime;
        int seconds = (int)time % 100;
        second = seconds;
        if(second==59)
        {
            time = 00;
            second = 00;
            minute++;
            
        }

    }
    void Minute()
    {
        if (minute == 59)
        {
            minute = 00;
            hour++;
        }
    }
    void Hour()
    {
        if(hour==18)
        {

            Light.GetComponent<LightControl>().Night = true;
        }
        if(hour==24)
        {
            hour = 00;
        }
        if(hour==6)
        {
            Light.GetComponent<LightControl>().Night = false;
        }
    }
}
