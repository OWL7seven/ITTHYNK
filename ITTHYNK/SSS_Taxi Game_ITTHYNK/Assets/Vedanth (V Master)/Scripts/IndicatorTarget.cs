using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IndicatorTarget : MonoBehaviour
{
    public GameObject PassengerFace;
    public Text Distance;
    public PassDestination DesiredLocation;
    public string nametarg;
    //Rect canvas;


    void Update()
    {
        if (DesiredLocation.current == true)
        {
            //Postion Placement
            //this.transform.position = Camera.main.WorldToScreenPoint(DesiredLocation.gameObject.transform.position);
            //this.transform.position =   new Vector3(Camera.main.WorldToScreenPoint(DesiredLocation.gameObject.transform.position).x, Camera.main.WorldToScreenPoint(DesiredLocation.gameObject.transform.position).y, this.transform.position.z);
            
            this.transform.position =   new Vector3(Camera.main.WorldToScreenPoint(DesiredLocation.gameObject.transform.position).x, this.transform.position.y, Camera.main.WorldToScreenPoint(DesiredLocation.gameObject.transform.position).y);
            
            //this.transform.position =   new Vector3(this.transform.position.x, Camera.main.WorldToScreenPoint(DesiredLocation.gameObject.transform.position).x, Camera.main.WorldToScreenPoint(DesiredLocation.gameObject.transform.position).y);
            
            /*Vector2 clamper = this.transform.GetComponent<RectTransform>().anchoredPosition;
            clamper.x = Mathf.Clamp(clamper.x, this.transform.GetComponent<RectTransform>().rect.width / 2, canvas.width - this.transform.GetComponent<RectTransform>().rect.width / 2);
            clamper.y = Mathf.Clamp(clamper.y, this.transform.GetComponent<RectTransform>().rect.height / 2, canvas.height - this.transform.GetComponent<RectTransform>().rect.height / 2);
            this.transform.GetComponent<RectTransform>().anchoredPosition = clamper;*/


            //insert distance between the player and the location
        }
        else
        {
            Destroy(this.gameObject, 0.25f);
        }
    }


    void Awake()
    {
        //canvas = GameObject.FindGameObjectWithTag("Indicator").GetComponent<Canvas>().pixelRect;
        nametarg = "Person wanna go " +  Random.Range(0,300000)   ;//DesiredLocation.name;   //Create a function later ot add names
    }
}
