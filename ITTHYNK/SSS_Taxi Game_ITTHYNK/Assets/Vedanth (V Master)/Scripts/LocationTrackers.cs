using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationTrackers : MonoBehaviour
{
    public GameObject[] Locations;

    private void Awake()
    {
        Locations = GameObject.FindGameObjectsWithTag("Loc");
    }

    public PassDestination SetDesPoint()
    {
        PassDestination dessy;
        int rnd = Random.Range(0, Locations.Length);
        dessy = Locations[rnd].GetComponent<PassDestination>();
        return dessy;
    }
}
