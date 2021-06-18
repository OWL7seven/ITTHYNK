using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiFeeMachine : MonoBehaviour
{
    public List<TaxiPassenger> Passengers = new List<TaxiPassenger>();
    public int PassTotal = 0;       // this can also just be Passengers.Count;
    public int PassDrop = 0;
    public float Score = 0;
    public static TaxiFeeMachine instance;
    public Transform seating;

    public Vector3 PrevLoc;
    float LocTime;
    public bool Grounded;


    private void Awake()
    {
        instance = this;
        PassTotal = 0;
        PassDrop = 0;
        Score = 0;
        PrevLoc = this.transform.position;
        Grounded = false;
        LocTime = 2;
    }

    void GroundCheck()
    {
        if (LocTime <= 0)
        {
            if (Grounded == true) PrevLoc = transform.position;
            LocTime = 2;
        }
        LocTime -= Time.deltaTime;
    }


    private void Update()
    {
        GroundCheck();
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Road") Grounded = true; //else Grounded = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Road") Grounded = false;
    }

}
