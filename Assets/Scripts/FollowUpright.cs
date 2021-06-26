using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUpright : MonoBehaviour
{
    public Transform parent;
    private Transform self;

    private void Start()
    {
        self = gameObject.transform;
    }
    void FixedUpdate()
    {
        self.position = parent.position;
    }
}
