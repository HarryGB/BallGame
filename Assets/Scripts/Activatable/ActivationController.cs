using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationController : MonoBehaviour
{
    public TriggerBrazier[] triggers;
    public Activatable[] activatables;
    [SerializeField]
    private bool activated = false;

    private void FixedUpdate()
    {
        if (!activated)
        {
            foreach (TriggerBrazier trigger in triggers)
            {
                if (!trigger.GetTriggered() || trigger.GetColour() == FlameColour.NONE)
                    return;
            }
            foreach (Activatable activatable in activatables)
            {
                if (!activatable.Activate())
                    Debug.LogError("Activatable " + activatable.gameObject.name + " returned false, please fix");
            }
            activated = true;
        }
    }
}
