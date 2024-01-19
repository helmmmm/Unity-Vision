using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;

    void Update()
    {
        Vector3 movementDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementDirection = -transform.right;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementDirection = transform.right;
        }

        Vector3 movement = movementDirection * movementSpeed * Time.deltaTime;
        transform.position += movement;
    }
}
