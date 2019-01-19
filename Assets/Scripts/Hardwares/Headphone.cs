﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headphone : Hardware
{
    public float maxFrequency; //kHz
    public float sensitivity; //dB

    public Headphone()
    {
    }

    public Headphone(string modelName,string manufacturer, float malfunctionRate, float cost, bool isMantadory, float maxFrequency, float sensitivity) : base(modelName, manufacturer, malfunctionRate, cost)
    {
        this.maxFrequency = maxFrequency;
        this.sensitivity = sensitivity;
    }
}

