using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetLamps : MonoBehaviour
{
  

  
    NavMeshAgent nav;
    LampsPosition lampPos;
   



    public int Counter = 0;
    public int HomeCounter = 0;


    public bool Path = false;
    public bool Home = false;
    public bool Time = false;
    public bool HomeCount = false;
    

    Vector3 FlightMan;
    Rigidbody Rigid;
 
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        lampPos = GetComponent<LampsPosition>();
        FlightMan = new Vector3(75,15,472);
        Rigid = GetComponent<Rigidbody>();
        
    

    }


    public void Transform()
    {



        if (Path == false)
        {

            Debug.Log("if döngüde");
            
            Path = true;
            nav.isStopped = false;
            nav.SetDestination(lampPos.Vectors[Counter]);
            

        }
       


    }

    void Update()
    {
        //if (wait == true) 
        Transform();
        if(Home==true)
        {
            nav.isStopped = false;
            nav.SetDestination(FlightMan);
            

        }
        Debug.Log(HomeCounter);


    }
    IEnumerator AnimeWait()
    {

        Rigid.constraints = RigidbodyConstraints.FreezeAll;
        Debug.Log("In the Wait");
        this.GetComponentInChildren<Rigidbody>();
        nav.isStopped = true;
        yield return new WaitForSeconds(3f);
        Rigid.constraints = RigidbodyConstraints.None;
        Path = false;
        
        
    }
   
            
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lights")
        {
            nav.isStopped = true;

            Debug.Log("çalıştı");
            Counter += 1;
            if (Counter == 24)
            {
                nav.isStopped = true;
                Path = true;
                Home = true;
                
            }
            else
            {
                StartCoroutine(AnimeWait());
                
            }
        }
        if(other.gameObject.tag=="LightmanH")
        {
            HomeCounter++;
            if(HomeCounter==2)
            {
                Debug.Log("Sayı tamam");
                Counter = 0;
                HomeCount = true;
               
            }
        }

    }


}
