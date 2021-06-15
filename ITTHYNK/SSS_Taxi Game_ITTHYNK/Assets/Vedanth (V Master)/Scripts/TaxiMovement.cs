using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TaxiMovement : MonoBehaviour
{
    
    [Space]
    [Header("Taxi Config")]
    public float Speed = 50f;
    public float RevSpeed = 25f;
    public float turning = 80f;
    public float weight = 10f;

    [Space]
    [Header("External")]

    public InputMain controls;
    public GameObject TaxiModel;
    public Transform COG; // Centre of Gravity
    Rigidbody rigi;

    [Space]
    [Header("Wheels")]

    public WheelCollider frontLeft, frontRight, rearLeft, rearRight;

    [Space]
    [Header("Forces")]

    float motorForce, brakeForce;

    [Space]
    [Header("Input Values")]

    float Acc, Rev, Tur, Dri;

    private void Awake()
    {
        controls = new InputMain();
        rigi = GetComponent<Rigidbody>();

        controls.PlayerTaxi.Accelerate.performed += _ => Accel();
        controls.PlayerTaxi.Reverse.performed += _ => Rever();
        controls.PlayerTaxi.Turning.performed += _ => Turn();
        controls.PlayerTaxi.Drift.performed += _ => Drifting();
    }

    void Accel()
    {
        Acc = Mathf.SmoothStep(Acc, Speed, Time.deltaTime * 12f);
        rigi.AddForce(-TaxiModel.transform.up * Acc, ForceMode.Acceleration);
        Debug.Log("Vroom!");
    }

    void Rever()
    {

    }

    void Turn()
    {

    }


    void Drifting()
    {

    }

    private void Update()
    {
        
    }

    void inputfecth(InputValue accc)
    {
       // InputValue val = GetComponent<PlayerInput>();
       // Acc = val.

            //Acc = controls.PlayerTaxi.Accelerate.ReadValue<>;
    }

    void ModelSet()
    {
        //frontLeft.motorTorque = controls.PlayerTaxi. * motorForce;
    }

}
