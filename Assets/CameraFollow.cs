using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public Vector3 offset;
    private Vector3 speedStuff;

    public float smoothSpeed;
    public CarMovement carMove;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref speedStuff, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
