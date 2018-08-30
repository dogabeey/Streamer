using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Hardware
{
    public int DPI;
    public int additionalButtons;

    public Mouse(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, bool isMantadory, int DPI, int additionalButtons) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {
        this.DPI = DPI;
        this.additionalButtons = additionalButtons;
    }
}
