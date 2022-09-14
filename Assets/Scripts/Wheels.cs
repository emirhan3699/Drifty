using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    public WheelCollider frontright;
    public WheelCollider frontleft;
    public Transform ontekersag;
    public Transform ontekersol;
    public Transform arkasað;
    public Transform arkasol;
    public float acý;
   


    void Update()
    {
        float y = SimpleInput.GetAxis("Horizontal") * acý;
        frontleft.steerAngle = y;
        frontright.steerAngle = y;
        ontekersag.localEulerAngles = new Vector3(0, frontright.steerAngle, 0);
        ontekersol.localEulerAngles = new Vector3(0, frontleft.steerAngle, 0);
        ontekersag.Rotate(0, 0, 100000 * Time.deltaTime);
        ontekersol.Rotate(0, 0, 100000 * Time.deltaTime);
        arkasað.Rotate(0, 0, 100000 * Time.deltaTime);
        arkasol.Rotate(0, 0, 100000 * Time.deltaTime);
        
    }
}
