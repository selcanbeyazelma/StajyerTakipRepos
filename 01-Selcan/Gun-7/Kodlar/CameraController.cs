using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float smoothTime = 5f;

    private float rotationY;
    private float currentX, currentY;
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        x *= rotationSpeed * Time.deltaTime;
        y*= rotationSpeed * Time.deltaTime;

        currentX = Mathf.Lerp (currentX, x, smoothTime * Time.deltaTime);
        currentY = Mathf.Lerp (currentY, y, smoothTime * Time.deltaTime);

        float rotationX = transform.localEulerAngles.y + currentX * rotationSpeed;

        rotationY += currentY *rotationSpeed;
        rotationY = Mathf.Clamp(rotationY, -90, 90);

        transform.localRotation = Quaternion.Euler(new Vector3(-rotationY, rotationX, 0));

    }
}
