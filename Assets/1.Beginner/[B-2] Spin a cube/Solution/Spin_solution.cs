using UnityEngine;
public class Spin_Solution : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    void Update()
    {
        float rotateX = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float rotateY = Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotateY, Space.World);
        transform.Rotate(Vector3.right, rotateX, Space.World);
    }
}