using UnityEngine;

public class VectorMovementSolution : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movementDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementDirection = transform.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Transform doesn't contain a "back" direction, 
            // so we use the negative of the forward direction
            movementDirection = -transform.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Transform doesn't contain a "left" direction, 
            // so we use the negative of the right direction
            movementDirection = -transform.right;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementDirection = transform.right;
        }

        Vector3 movement = movementDirection * movementSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }
}
