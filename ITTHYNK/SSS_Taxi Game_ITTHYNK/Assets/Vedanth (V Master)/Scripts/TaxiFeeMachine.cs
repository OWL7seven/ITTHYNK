using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiFeeMachine : MonoBehaviour
{
    public List<TaxiPassenger> Passengers = new List<TaxiPassenger>();
    public int PassTotal = 0;
    public int PassDrop = 0;
    public float Score = 0;
    public static TaxiFeeMachine instance;

    private void Awake()
    {
        instance = this;
        PassTotal = 0;
        PassDrop = 0;
        Score = 0;
    }



}
