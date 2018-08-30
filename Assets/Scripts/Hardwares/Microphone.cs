using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Microphone : Hardware
{
    public float maxFrequency; //kHz
    public float sensitivity; //dB

    public Microphone(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, bool isMantadory, float maxFrequency, float sensitivity) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {
        this.maxFrequency = maxFrequency;
        this.sensitivity = sensitivity;
    }
}

