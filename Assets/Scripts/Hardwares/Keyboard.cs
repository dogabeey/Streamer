using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : Hardware
{
    public int additionalButtons;

    public Keyboard()
    {

    }
    public Keyboard(string modelName,string manufacturer, float malfunctionRate, float cost,  int additionalButtons) : base(modelName, manufacturer, malfunctionRate, cost)
    {
        this.additionalButtons = additionalButtons;
    }
}
