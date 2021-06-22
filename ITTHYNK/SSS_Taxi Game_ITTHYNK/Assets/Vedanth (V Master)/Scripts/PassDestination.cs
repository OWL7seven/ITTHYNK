using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VCompass;

public class PassDestination : MonoBehaviour
{
    public string LocationName;
    public GameObject Parti;
    public bool current = false;
    public IndicatorTarget Target;

    private void Start()
    {
        this.name = LocationName;
    }

    public void notCurrent()
    {
        current = false;
    }

    public void iscurrent()
    {
        current = true;
    }

    private void Update()
    {
        if (current == true) Parti.SetActive(true); else
        {
            if (current == false) Parti.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(other.gameObject.GetComponent<TaxiFeeMachine>().Passengers.Count > 0)
            {
                foreach(TaxiPassenger boi in other.gameObject.GetComponent<TaxiFeeMachine>().Passengers)
                {
                    if(boi.DestinationPoint == this)
                    {
                        if(boi.dropped == false)
                        {
                            other.gameObject.GetComponent<TaxiFeeMachine>().PassDrop++;
                            boi.gameObject.SetActive(false);
                            boi.gameObject.transform.position = this.transform.position;
                            boi.transform.SetParent(this.transform);
                            boi.dropped = true;
                            boi.PassCell.gameObject.SetActive(false);
                            boi.Card.gameObject.SetActive(true);
                            current = false;

                            //Jerome
                            PedestrianManager.Instance.RemovePedestrian(boi);
                            //
                        }
                    }
                }
            }
        }
    }

}
