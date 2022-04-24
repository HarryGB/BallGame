using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FlameColour
{
    NONE,
    RED,
    BLUE,
    GREEN,
    WHITE
}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DataContainer", order = 1)]
public class DataContainer : ScriptableObject
{
    [SerializeField]
    private FlameColour flameColours; //for quick reference in editor
    [SerializeField]
    private Color[] FlameValues;

    public Color GetColour(FlameColour name)
    {
        return FlameValues[(int)name];
    }
}
