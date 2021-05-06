using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rigbod;
    private void Start()
    {
        rigbod = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigbod.AddTorque(new Vector3(speed, 0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigbod.AddTorque(new Vector3(-1 * speed, 0, -1 * speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigbod.AddTorque(new Vector3(speed, 0, -1 * speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigbod.AddTorque(new Vector3(-1 * speed, 0, speed));
        }
        if (Input.GetKey(KeyCode.R))
        {
            rigbod.position = new Vector3(0, 0.5f, 0);
            rigbod.velocity = Vector3.zero;
        }
    }
}
