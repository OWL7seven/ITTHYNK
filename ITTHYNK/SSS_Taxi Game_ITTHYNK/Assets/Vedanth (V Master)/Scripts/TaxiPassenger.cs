using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiPassenger : MonoBehaviour
{
    public bool Picked = false;
    GameObject Taxi;
    public float PassTime;
    public PassDestination DestinationPoint;

    void Start()
    {
        PassTime = 0;
        DestinationPoint = GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().SetDesPoint();
    }

    void Update()
    {
        if(Picked == true)
        {
            TimeToRide();
        }
    }


    void TimeToRide()
    {
        DestinationPoint.current = true;
        if(DestinationPoint.Target == null)    GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().CreateIndicator(DestinationPoint);
    }
}
