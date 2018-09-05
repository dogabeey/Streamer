using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : Hardware
{
    public Webcam()
    {

    }
    public Webcam(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, bool isMantadory) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {

    }
}
