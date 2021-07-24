using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameBobbing : MonoBehaviour
{
    public Rigidbody external;
    public float speed;
    public float scale;
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(external.angularVelocity.x * scale, external.angularVelocity.y * scale, external.angularVelocity.z * scale), speed);
    }
}
