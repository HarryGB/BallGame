using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTrigger : MonoBehaviour
{
    private MapController controller;
    private bool active = true;
    private void Start()
    {
        controller = FindObjectOfType<MapController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            Debug.Log("Collision!");
            if (other.gameObject.tag.Equals("Player"))
            {
                controller.UpdateRooms();
                active = false;
            }
        }
    }
}
