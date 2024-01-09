using UnityEngine;

public class Move_Solution : MonoBehaviour 
{
public float speed = 5.0f;
    void Update() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 newPosition = transform.position + movement * speed * Time.deltaTime;
        
        // Ensure the new position is within boundaries 
        newPosition.x = Mathf.Clamp(newPosition.x, -10f, 10f); 
        newPosition.z = Mathf.Clamp(newPosition.z, -10f, 10f);
        
        transform.position = newPosition; 
    }
}
