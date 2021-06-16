using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TaxiMovement : MonoBehaviour
{
    
    [Space]
    [Header("Taxi Config")]
    public float Speed = 10f;
    public float RevSpeed = 5f;
    public float turning = 8f, torque = 6f;
    public float weight = 1f;

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

    float movement, rpm;
    float Acc , Rev, Tur, Dri;

    private void Awake()
    {
        //Input System
        controls = new InputMain();
        rigi = GetComponent<Rigidbody>();
        controls.Enable();
       // controls.PlayerTaxi.Accelerate.performed += _ => Accel();
        controls.PlayerTaxi.Accelerate.performed += ctx => rpm = ctx.ReadValue<float>();
        controls.PlayerTaxi.Accelerate.performed += ctx => Rev = ctx.ReadValue<float>();
        controls.PlayerTaxi.Accelerate.canceled += ctx => rpm = ctx.ReadValue<float>();
        controls.PlayerTaxi.Reverse.performed += _ => Rever();
        controls.PlayerTaxi.Turning.performed += ctx => movement = ctx.ReadValue<float>();      //Turn();
        controls.PlayerTaxi.Turning.canceled += ctx => movement = ctx.ReadValue<float>();      
        controls.PlayerTaxi.Drift.performed += _ => Drifting();


    }


    void floatlimiter(float value, float minV, float maxV)
    {
        float clamp = Mathf.Clamp(value, minV, maxV);
    }

    private void FixedUpdate()
    {
        //vroom vroom
        Acc = Mathf.SmoothStep(Acc, Speed, Time.deltaTime * (rpm * 2));
        floatlimiter(Acc, 0, 10);
        //  rigi.AddForce(TaxiModel.transform.TransformDirection(Vector3.forward) * Acc, ForceMode.Acceleration);
        // rigi.AddForce(TaxiModel.transform.right * Acc, ForceMode.Acceleration);
        //rigi.AddForceAtPosition(Time.deltaTime * transform.TransformDirection(Vector3.right) * (turning * movement), this.transform.position);
        //rigi.AddTorque(Time.deltaTime * transform.TransformDirection(Vector3.up) * torque);
        // rigi.AddForce(-Time.deltaTime * transform.TransformDirection(Vector3.forward) * transform.InverseTransformPoint(rigi.velocity).x * (Speed * rpm ));

        rigi.AddForce(TaxiModel.transform.TransformDirection(Vector3.right) * Acc, ForceMode.Acceleration);

        //        Debug.Log(rpm);
      //  Debug.Log(Acc);

    

    }


    
    void Accel()
    {
        Debug.Log("Vroom!");
     //   Acc = Mathf.SmoothStep(Acc, Speed, Time.deltaTime * (rpm * 10f) );
      //  rigi.AddForce(TaxiModel.transform.right * Acc, ForceMode.Acceleration);
        
           

          //  rigi.AddForceAtPosition(Time.deltaTime * transform.TransformDirection(Vector3.forward) * Mathf.Pow(3- ))
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
        //Rotatemove 
        //float turnspeed = movement * (turning * Time.deltaTime);
        // transform.Rotate(turnspeed, 0, 0);

        //Angle turn
        float angle = turning * movement * Time.deltaTime * Rev;
        //transform.rotation.eulerAngles.y += angle;
        transform.Rotate(this.transform.rotation.x,  this.transform.rotation.y, angle);    
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
