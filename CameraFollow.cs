using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 7.0f;
    public float sensitivityX = 3.0f;
    public float sensitivityY = 1.5f;
    public float smoothTime = 0.3f;
    public Vector2 rotationYLimits = new Vector2(-40f, 80f);
    public float heightOffset = 6.0f;

    private float currentX = 0f;
    private float currentY = 0f;
    private Vector3 currentVelocity = Vector3.zero;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        currentX = transform.eulerAngles.y;
        currentY = transform.eulerAngles.x;
    }

    void LateUpdate()
    {
        currentX += Input.GetAxis("Mouse X") * sensitivityX;
        currentY -= Input.GetAxis("Mouse Y") * sensitivityY;
        currentY = Mathf.Clamp(currentY, rotationYLimits.x, rotationYLimits.y);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        Vector3 targetPosition = target.position + new Vector3(0, heightOffset + 15f, 0);
        Vector3 desiredPosition = targetPosition - (rotation * Vector3.forward * distance);
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, smoothTime);
        transform.LookAt(targetPosition);
    }
}
