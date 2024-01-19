using UnityEngine;

public class CollisionDetectionSolution : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Change color upon collision
        renderer.material.color = Color.red;

        // Optional: print the name of the collided object
        Debug.Log("Collided with: " + collision.gameObject.name + "\n");
    }

    void OnCollisionExit(Collision collision)
    {
        // Revert color when collision ends
        renderer.material.color = Color.white;
    }
}
