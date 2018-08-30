using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : Hardware
{
    public Vector2 resolution;

    public Monitor(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, bool isMantadory, Vector2 resolution) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {
        this.resolution = resolution;
    }
}
