using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerBrazier : MonoBehaviour
{
    protected ColourController controller;
    protected bool triggered;
    protected AudioController audioCon;
    private void Start()
    {
        controller = this.GetComponent<ColourController>();
        triggered = false;
        audioCon = FindObjectOfType<AudioController>();
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
