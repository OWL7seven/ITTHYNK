using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PassengerCell : MonoBehaviour
{
    public Image Colour;
    public Text Time, Location;
    public TaxiPassenger Pass;

    private void Update()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
        Colour.color = Pass.colour;
        //Time.text = Mathf.FloorToInt(Pass.PassTime % 60) + " Seconds";
        //Time.text = (int)(Pass.PassTime +1) + " Seconds";
        //Time.text = (int)(Pass.PassTime +1) + " Seconds";
        Time.text = "Time: " + FormatTime(Pass.PassTime);
        Location.text = Pass.DestinationPoint.LocationName;
    }

    string FormatTime(float time)
    {
        TimeSpan ts = TimeSpan.FromSeconds(time);
        if (time >= 3600) return String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        else
        {
            if (time >= 60) return String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            else
            {
                return (int)time + "";
            }
        }
    }
}
