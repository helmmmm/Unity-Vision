using UnityEngine;

public class Scale_Solution : MonoBehaviour
{
    public float scaleSpeed = 0.5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Scale up uniformly
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Scale down uniformly
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
        }

        // Prevent negative scaling
        transform.localScale = new Vector3(
            Mathf.Max(transform.localScale.x, 0.1f),
            Mathf.Max(transform.localScale.y, 0.1f),
            Mathf.Max(transform.localScale.z, 0.1f)
        );
    }
}
