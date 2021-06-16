using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VCompass;

public class LocationTrackers : MonoBehaviour
{
    public GameObject[] Locations;
    public IndicatorTarget TargetLocPoint;

    private void Awake()
    {
        Locations = GameObject.FindGameObjectsWithTag("Loc");
    }

    public void CreateIndicator(PassDestination DesiredPoint)   //Remember to add the character image later
    {
        //GameObject Target = Instantiate(TargetLocPoint.gameObject, Camera.main.WorldToScreenPoint(DesiredPoint.transform.position), TargetLocPoint.gameObject.transform.rotation);
        GameObject Target = TargetLocPoint.gameObject;
        Target.GetComponent<IndicatorTarget>().DesiredLocation = DesiredPoint;
        DesiredPoint.Target = Target.GetComponent<IndicatorTarget>();
        //Target.transform.SetParent(GameObject.FindGameObjectWithTag("Indicator").transform);  
        //Target.transform.SetParent(HoriCompass.Compass.Waypoints.transform);  

        HoriCompass.Compass.add(Target.name, new Ways()
        {
            PassengerFace = Target.GetComponent<IndicatorTarget>().PassengerFace.transform.parent.transform,
            Player = HoriCompass.Compass.PlayerTaxi,
            DesiredLocation = Target.GetComponent<IndicatorTarget>().DesiredLocation.transform
        }); ;

    }

    public PassDestination SetDesPoint()
    {
        PassDestination dessy;
        int rnd = Random.Range(0, Locations.Length);
        dessy = Locations[rnd].GetComponent<PassDestination>();
        return dessy;
    }
}
