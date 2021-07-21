using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatableMove : Activatable
{
    public Vector3 targetCoords;

    public override bool Activate()
    {
        Debug.Log("Activatable " + gameObject.name + " activated");
        StartCoroutine(LerpPosition(targetCoords, 5));
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
