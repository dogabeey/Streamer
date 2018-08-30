using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSupply : Hardware
{
    [Range(0, 100)] float malfReductionRate;

    public PowerSupply(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, float malfReductionRate, bool isMantadory) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {
        this.malfReductionRate = malfReductionRate;
    }
}
