using UnityEngine;

public class PlatformRotator : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        float move = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, -move, 0);
    }
}
