using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed;
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed);
        //transform.position = new Vector3(target.position.x, 1.5f, target.position.z);
    }
}
