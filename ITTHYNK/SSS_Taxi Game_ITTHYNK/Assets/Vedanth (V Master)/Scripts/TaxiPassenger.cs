using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiPassenger : MonoBehaviour
{
    public bool Picked = false;
    GameObject Taxi;
    public float PassTime, starttime;
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<TaxiFeeMachine>().Passengers.Add(this);
            PassNum = other.gameObject.GetComponent<TaxiFeeMachine>().Passengers.Count;
            this.gameObject.transform.position = other.gameObject.GetComponent<TaxiFeeMachine>().seating.position;
            starttime = Time.deltaTime;
            this.gameObject.transform.SetParent(other.gameObject.GetComponent<TaxiFeeMachine>().seating);
            this.gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);    //Temp solution
            Picked = true;
        }
    }


    void TimeToRide()
    {
        DestinationPoint.current = true;
        if(DestinationPoint.Target == null)    GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().CreateIndicator(DestinationPoint);
        if (dropped == false) PassTime = Time.deltaTime - starttime;
        Lines.enabled = true;
    }
}
