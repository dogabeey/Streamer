using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : Hardware
{
    public int additionalButtons;

    public Keyboard(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, bool isMantadory, int additionalButtons) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {
        this.additionalButtons = additionalButtons;
    }
}
