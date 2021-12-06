using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//brazier that takes any colour
public class TriggerBrazierChanging : TriggerBrazier
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Changing Brazier Collision, making it " + collision.gameObject.GetComponent<ColourController>().currentColour.ToString());
            controller.UpdateColour(collision.gameObject.GetComponent<ColourController>().currentColour);
            controller.ChangeVisibility(true);
            triggered = true;

            audioCon.AddTrack((int)controller.currentColour);
        }
    }
}
