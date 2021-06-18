using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTaxi : MonoBehaviour
{
    Vector3 target, pickup, heaven;
    bool moving = false, height = false, start = false;
    public float TimeToArrive = 1.5f;
    public GameObject parti;

    Vector3 targetSetter()
    {
        float x = this.GetComponent<TaxiFeeMachine>().PrevLoc.x;
        float y = this.GetComponent<TaxiFeeMachine>().PrevLoc.y + 5;
        float z = this.GetComponent<TaxiFeeMachine>().PrevLoc.z;
        Vector3 set = new Vector3(x, y, z);
        return set;
    }

    private void Update()
    {
        target = targetSetter();
        if (moving == true) { CloudLift(); parti.SetActive(true); }
        if (moving == false) parti.SetActive(false);
    }

    public void RespawnToLastPoint()
    {
        moving = true;
        pickup = transform.position;
        heaven = new Vector3(pickup.x, pickup.y + 15, pickup.z);
    }

    void CloudLift()
    {

        //lift
        if (start == false)
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
            float step = TimeToArrive * Time.deltaTime * 25;
            transform.position = Vector3.MoveTowards(transform.position, heaven, step);
            moving = true;
            //heaven checklist
            if (this.transform.position == heaven) start = true;
            if (this.transform.position != heaven) start = false;
        }

        if (start == true)
        {
            //flight check
            if (this.transform.position == target) height = true;
            if (this.transform.position != target) height = false;

            //to air
            if (height == false)
            {
                this.GetComponent<Rigidbody>().isKinematic = true;
                float step = TimeToArrive * Time.deltaTime * 50;
                transform.position = Vector3.MoveTowards(transform.position, target, step);
                moving = true;
            }

            //fall
            if (height == true)
            {
                this.GetComponent<Rigidbody>().isKinematic = false;
                start = false;
                moving = false;
            }
        }
    }
}
