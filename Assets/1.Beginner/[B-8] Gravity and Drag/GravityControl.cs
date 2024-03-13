using UnityEngine;

public class GravityControl : MonoBehaviour
{
    public Rigidbody heavyBallRigidbody;
    public Rigidbody lightBallRigidbody;

    // Use this for initialization
    void Start()
    {
        // Ensure the rigidbodies are linked in the inspector
        if (!heavyBallRigidbody || !lightBallRigidbody)
        {
            Debug.LogError("Rigidbodies not assigned in GravityControl script.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle gravity when 'G' is pressed
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Placeholder for toggling gravity
        }
    }
}
