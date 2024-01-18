using UnityEngine;

public class Forces_Solution : MonoBehaviour
{
    public float forceMagnitude = 5.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {   
        // Apply a forward force when the user presses the Up arrow key
        if (Input.GetKeyDown("up"))
        {
            // Apply a forward force
            rb.AddForce(Vector3.forward * forceMagnitude, ForceMode.Impulse);
        }

        // Apply a backward force when the user presses the Down arrow key
        else if (Input.GetKeyDown("down"))
        {
            // Apply a backward force
            rb.AddForce(-Vector3.forward * forceMagnitude, ForceMode.Impulse);
        }

        // Apply a leftward force when the user presses the Left arrow key
        else if (Input.GetKeyDown("left"))
        {
            // Apply a leftward force
            rb.AddForce(-Vector3.right * forceMagnitude, ForceMode.Impulse);
        }

        // Apply a rightward force when the user presses the Right arrow key
        else if (Input.GetKeyDown("right"))
        {
            // Apply a rightward force
            rb.AddForce(Vector3.right * forceMagnitude, ForceMode.Impulse);
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply an upward force
            Vector3 forceDirection = Vector3.up;
            rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
        }
    }
}
