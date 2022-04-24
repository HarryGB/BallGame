using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTrigger : MonoBehaviour
{
    private MapController controller;
    private bool active = true;
    private AudioController audioCon;

    private void Start()
    {
        controller = FindObjectOfType<MapController>();
        audioCon = FindObjectOfType<AudioController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active && other.tag == "Player")
        {
            Debug.Log("Entering next room");
            if (other.gameObject.tag.Equals("Player"))
            {
                controller.UpdateRooms();
                active = false;
                audioCon.ResetTracks();
                //returns object to previous position, not a nice way of doing it
                GetComponentInParent<ActivatableMove>().Activate();
            }
        }
    }
}
