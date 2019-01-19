using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : Hardware
{
    public Webcam()
    {

    }
    public Webcam(string modelName,string manufacturer, float malfunctionRate, float cost, bool isMantadory) : base(modelName, manufacturer, malfunctionRate, cost)
    {

    }
}
