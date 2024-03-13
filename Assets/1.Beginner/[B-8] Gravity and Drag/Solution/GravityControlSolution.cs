using UnityEngine;

public class GravityControlSolution : MonoBehaviour
{
    public Rigidbody heavyBallRigidbody;
    public Rigidbody lightBallRigidbody;
    private bool gravityEnabled = true;

    void Start()
    {
        if (!heavyBallRigidbody || !lightBallRigidbody)
        {
            Debug.LogError("Rigidbodies not assigned in GravityControl script.");
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            gravityEnabled = !gravityEnabled;
            heavyBallRigidbody.useGravity = gravityEnabled;
            lightBallRigidbody.useGravity = gravityEnabled;
            
            // Optional: Print the current state of gravity
            Debug.Log("Gravity enabled: " + gravityEnabled);
        }
    }
}
