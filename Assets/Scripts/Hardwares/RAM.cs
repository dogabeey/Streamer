using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAM : Hardware
{
    public enum RAMType
    {
        SDRAM,
        SDR,
        DDR,
        DDR2,
        DDR3,
        DDR4
    }

    public RAMType type;
    public float memory; // in MBs
    
    public RAM(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, RAMType type, float memory, bool isMantadory) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {
        this.memory = memory;
        this.type = type;
    }
}