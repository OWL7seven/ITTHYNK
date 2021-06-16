using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiPassenger : MonoBehaviour
{
    public bool Picked = false;
    GameObject Taxi;
    public float PassTime;
    public PassDestination DestinationPoint;
    public Color colour;
    public LineArrow Lines;
    public int PassNum;
    public bool dropped = false;

    void Start()
    {
        Lines.enabled = false;
        colour = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
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
        //Add in timer function
        //some function to jump into the taxi
        Lines.enabled = true;
    }
}
