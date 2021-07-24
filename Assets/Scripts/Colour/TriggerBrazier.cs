using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerBrazier : MonoBehaviour
{
    protected ColourController controller;
    protected bool triggered;
    private void Start()
    {
        controller = this.GetComponent<ColourController>();
        triggered = false;
    }

    public bool GetTriggered()
    { 
        return triggered; 
    }

    public FlameColour GetColour()
    {
        return controller.currentColour;
    }
}
