using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationTrackers : MonoBehaviour
{
    public GameObject[] Locations;
    public IndicatorTarget TargetLocPoint;

    private void Awake()
    {
        Locations = GameObject.FindGameObjectsWithTag("Loc");
    }

    public void CreateIndicator(PassDestination DesiredPoint)
    {
        GameObject Target = Instantiate(TargetLocPoint.gameObject, Camera.main.WorldToScreenPoint(DesiredPoint.transform.position), TargetLocPoint.gameObject.transform.rotation);
        Target.GetComponent<IndicatorTarget>().DesiredLocation = DesiredPoint;
        DesiredPoint.Target = Target.GetComponent<IndicatorTarget>();
        Target.transform.SetParent(GameObject.FindGameObjectWithTag("Indicator").transform);       
    }

    public PassDestination SetDesPoint()
    {
        PassDestination dessy;
        int rnd = Random.Range(0, Locations.Length);
        dessy = Locations[rnd].GetComponent<PassDestination>();
        return dessy;
    }
}
