using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Rigidbody rigidbody;
    public Transform rodderPosition;
    public Transform targetPosition;

    public float thrust = 200;
    public float torque = 10;

    public float currentThrust = 0;

    public void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        float deltaTime = Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.W))
            currentThrust += thrust;

        if(Input.GetKeyDown(KeyCode.S))
            currentThrust -= thrust;

        Vector3 velocity = transform.forward * currentThrust;

        Vector3 rotation = Vector3.up * deltaTime * torque;

        transform.eulerAngles -= rotation * Input.GetAxis("Horizontal");

        rigidbody.AddForce(velocity, ForceMode.Acceleration);
    }
}
