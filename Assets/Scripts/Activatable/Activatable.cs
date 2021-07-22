using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Activatable : MonoBehaviour
{
    protected bool activated = false;
    public abstract bool Activate();
}
