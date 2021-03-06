using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineArrow : MonoBehaviour
{
    public float width = 0.75f;
    public LineRenderer Line;
    public Material mat;
    public TaxiPassenger Passenger;

    private void Start()
    {
        Line = this.GetComponent<LineRenderer>();     //gameObject.AddComponent<LineRenderer>();
        Line.startWidth = width;
        Line.endWidth = width;
        Line.positionCount = 2;
        Line.materials[0] = mat;
        Line.enabled = false;
        Line.materials[0].SetColor("_EmissionColor", Passenger.colour);
        Line.materials[0].SetColor("_Albedo", Passenger.colour);
        Line.materials[0].SetColor("_Base Map", Passenger.colour);
        Line.materials[0].SetColor(0, Passenger.colour);
    }

    private void Update()
    {
        Line.materials[0] = mat;
        Line.materials[0].SetColor("_EmissionColor", Passenger.colour);
        Line.materials[0].SetColor("_Albedo", Passenger.colour);
        Line.materials[0].SetColor("_Base Map", Passenger.colour);
        Line.materials[0].SetColor(0, Passenger.colour);
        Line.startColor = Passenger.colour;
        Line.endColor = Passenger.colour;

        if(Passenger.dropped == false)
        {
            Line.enabled = true;
            Line.SetPosition(0, TaxiFeeMachine.instance.transform.position);
            Line.SetPosition(1, Passenger.DestinationPoint.transform.position);
        }

        if(Passenger.dropped == true)
        {
            Line.enabled = false;
        }
    }

}
