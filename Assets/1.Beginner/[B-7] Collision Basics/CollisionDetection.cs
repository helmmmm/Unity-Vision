using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Change the color of the sphere when it collides with another object,
    // and print the name of the collided object
    

    // Revert the color of the sphere when it stops colliding with another object
}
