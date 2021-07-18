using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSource : MonoBehaviour
{
    public FlameColour sourceColour;
    private ColourController controller;

    private void Start()
    {
        controller = this.GetComponent<ColourController>();
        controller.UpdateColour(sourceColour);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ColourController>().UpdateColour(sourceColour);
        }
    }
}
