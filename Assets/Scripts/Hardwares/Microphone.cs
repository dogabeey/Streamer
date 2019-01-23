using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Microphone : Hardware
{
    public float maxFrequency; //kHz
    public float sensitivity; //dB

    public Microphone()
    {

    }
    public Microphone(string modelName,string manufacturer, float malfunctionRate, float cost,  float maxFrequency, float sensitivity) : base(modelName, manufacturer, malfunctionRate, cost)
    {
        this.maxFrequency = maxFrequency;
        this.sensitivity = sensitivity;
    }
}

