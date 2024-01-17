using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_Experiment_Solution : MonoBehaviour
{
    public float forceMagnitude = 5.0f;
    public float torqueMagnitude = 15.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Apply a forward force
            // transform.forward will move the cube in it's local forward direction
            // Vector3.forward will move the cube in the world forward direction
            rb.AddForce(Vector3.forward * forceMagnitude, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            // Apply a torque
            rb.AddTorque(Vector3.up * torqueMagnitude, ForceMode.Impulse);
        }
    }

}
