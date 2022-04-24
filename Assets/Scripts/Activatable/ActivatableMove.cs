using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatableMove : Activatable
{
    [SerializeField]
    private Vector3 targetCoordsRelative; //relative to start position
    [SerializeField]
    private bool reversable;
    [SerializeField]
    private int moveDuration;

    private Vector3 startCoords;
    private Vector3 targetCoords;

    private void Start()
    {
        startCoords = this.transform.position;
        targetCoords = startCoords + targetCoordsRelative;
    }

    public override bool Activate()
    {
        Debug.Log("running activate");
        if (!activated)
        {
            Debug.Log("Activatable " + gameObject.name + " activated");
            StartCoroutine(LerpPosition(targetCoords, moveDuration));
            activated = true;
        }
        else if (reversable)
        {
            Debug.Log("Activatable " + gameObject.name + " REVERSING");
            StartCoroutine(LerpPosition(startCoords, moveDuration));
            activated = true;
            reversable = false;
        }
        return true;
    }

    //borrowed from https://gamedevbeginner.com/the-right-way-to-lerp-in-unity-with-examples/
    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
