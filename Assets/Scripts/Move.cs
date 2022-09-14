using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    static public Vector3 MoveForce;
    public float MoveSpeed = 8;
    public float steerAngle = 20;
    public float Traction = 1;
    public float MaxSpeed = 2;
    public float Drag = 093f;
    static public float angle;
    void Update()
    {
            //Movement
            MoveForce += transform.forward * MoveSpeed * Time.deltaTime;
            transform.position += MoveForce * Time.deltaTime;
            MoveForce *= Drag;
            MoveForce = Vector3.ClampMagnitude(MoveForce, MaxSpeed);
        //Steering
            float steerInpuut = SimpleInput.GetAxis("Horizontal");
            transform.Rotate(Vector3.up * steerInpuut * MoveForce.magnitude * steerAngle * Time.deltaTime);
            //trac
            MoveForce = Vector3.Lerp(MoveForce.normalized, transform.forward, Traction * Time.deltaTime) * MoveForce.magnitude;
            Debug.DrawRay(transform.position, MoveForce.normalized * 3);
            Debug.DrawRay(transform.position, transform.forward * 3, Color.blue);
            angle = Vector3.Angle(MoveForce.normalized, transform.forward);
        if(angle>45)
        {
            GameObject.FindGameObjectWithTag("trail").GetComponent<TrailRenderer>().emitting = true;
            GameObject.FindGameObjectWithTag("trails").GetComponent<TrailRenderer>().emitting = true;
            ScoreSc.scoreValue += 1;
        }
        if(angle<45)
        {
            GameObject.FindGameObjectWithTag("trail").GetComponent<TrailRenderer>().emitting = false;
            GameObject.FindGameObjectWithTag("trails").GetComponent<TrailRenderer>().emitting = false;
        }
        
    }
}
