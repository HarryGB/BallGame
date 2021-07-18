using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBrazier : MonoBehaviour
{
    private ColourController controller;
    private bool triggered; 
    private void Start()
    {
        controller = this.GetComponent<ColourController>();
        triggered = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !triggered)
        {
            if (controller.defaultColour == collision.gameObject.GetComponent<ColourController>().currentColour)
            {
                controller.ToggleVisibility();
                triggered = true;
            }
        }
    }
}
