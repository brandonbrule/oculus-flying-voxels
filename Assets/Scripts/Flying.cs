using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour {

    public float _cameraRotationSpeed = 1f;
    public float forceMultiplier = 1f;

    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update () {

        // Look Up and Down Y Access 
        var PrimaryThumbstick = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        transform.eulerAngles = new Vector3(PrimaryThumbstick.y * -1, transform.eulerAngles.y, transform.eulerAngles.z);

        // Barrel Roll Rotate Z
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))

        {
            rb.AddForce(Vector3.up * forceMultiplier);
            //rotateBarrelRoll(false);
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            rb.AddForce(Vector3.down * forceMultiplier);
            //rotateBarrelRoll(true);
        }

        // Boost Up & Down
        if (OVRInput.Get(OVRInput.Button.One))

        {
            //rb.AddForce(Vector3.up * forceMultiplier);
        }

        if (OVRInput.Get(OVRInput.Button.Two))

        {
            //rb.AddForce(Vector3.down * forceMultiplier);
        }

    }

    // True is Right
    // False is Left
    void rotateBarrelRoll(bool rotateRight)
    {
        float angle = transform.eulerAngles.z;
        if (rotateRight)
        {
            angle += _cameraRotationSpeed;
        }
        else
        {
            angle -= _cameraRotationSpeed;
        }
    
       transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angle);
    }


}
