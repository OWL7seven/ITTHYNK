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

}
