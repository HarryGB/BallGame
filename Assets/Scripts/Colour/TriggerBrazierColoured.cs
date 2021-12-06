using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//brazier that takes specific colour
public class TriggerBrazierColoured : TriggerBrazier
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player") && !triggered)
        {
            if (controller.defaultColour == collision.gameObject.GetComponent<ColourController>().currentColour)
            {
                Debug.Log("Coloured Brazier Collision, making it " + collision.gameObject.GetComponent<ColourController>().currentColour.ToString());
                controller.UpdateColour(controller.defaultColour);
                controller.ChangeVisibility(true);
                triggered = true;

                audioCon.AddTrack((int)controller.currentColour);
            }
        }
    }
}
