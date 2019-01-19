using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Hardware
{
    public int DPI;
    public int additionalButtons;

    public Mouse()
    {

    }
    public Mouse(string modelName,string manufacturer, float malfunctionRate, float cost, bool isMantadory, int DPI, int additionalButtons) : base(modelName, manufacturer, malfunctionRate, cost)
    {
        this.DPI = DPI;
        this.additionalButtons = additionalButtons;
    }
}
