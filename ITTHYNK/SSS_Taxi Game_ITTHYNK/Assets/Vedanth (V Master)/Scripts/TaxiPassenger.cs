using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public PassengerCell PassCell;
    public PassengerCards Card;
    public Sprite Face;

    //Jerome
    private Pedestrian pedestrian;
    public Pedestrian GetPedestrian()
    {
        return pedestrian;
    }
    //

    void Start()
    {
        Lines.enabled = false;
        colour = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        PassTime = 0;
        DestinationPoint = LocationTrackers.Instance.SetDesPoint();
        Face = GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().PassengerFaces[Random.Range(0, GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().PassengerFaces.Length)];
        pedestrian = gameObject.GetComponentInParent<Pedestrian>();
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
            //Jerome
            if (!pedestrian.active)
            {
                 return;
            }
            //

            other.gameObject.GetComponent<TaxiFeeMachine>().Passengers.Add(this);
            PassNum = other.gameObject.GetComponent<TaxiFeeMachine>().Passengers.Count;
            this.gameObject.transform.position = other.gameObject.GetComponent<TaxiFeeMachine>().seating.position;
            starttime = Time.deltaTime;
            this.gameObject.transform.SetParent(other.gameObject.GetComponent<TaxiFeeMachine>().seating);
            this.gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);    //Temp solution
            if(PassCell == null)   CellGenerate();
            if (Card == null) CardGen();
            Picked = true;

            //Jerome
            pedestrian.EnterTaxi();
            //
        }
    }

    void CardGen()
    {
        GameObject cardy = Instantiate(GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().PassCardBase.gameObject, GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().CardHolder.transform.position, GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().PassCardBase.gameObject.transform.rotation);
        cardy.transform.SetParent(GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().CardHolder.transform);
        cardy.transform.localScale = new Vector3(1, 1, 1);
        Card = cardy.GetComponent<PassengerCards>();
        Card.Face.sprite = this.Face;
        Card.Colour.color = this.colour;
        Card.gameObject.SetActive(false);
    }

    void CellGenerate()
    {
        GameObject Cell = Instantiate(GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().PCell.gameObject, GameObject.FindGameObjectWithTag("Pass").transform.position, GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().PCell.gameObject.transform.rotation);
        Cell.transform.SetParent(GameObject.FindGameObjectWithTag("Pass").transform);
        PassCell = Cell.GetComponent<PassengerCell>();
        PassCell.Pass = this;
    }

    void TimeToRide()
    {
        DestinationPoint.current = true;
        if(DestinationPoint.Target == null)    GameObject.FindGameObjectWithTag("LocMaster").GetComponent<LocationTrackers>().CreateIndicator(DestinationPoint);
        //if (dropped == false) PassTime = Time.deltaTime - starttime;
        if (dropped == false) PassTime += Time.deltaTime;
        Lines.enabled = true;
       // Debug.Log(PassTime);
    }
}
