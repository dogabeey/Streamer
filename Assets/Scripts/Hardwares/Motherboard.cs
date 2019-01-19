using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Motherboard : Hardware
{
    public RAM.RAMType ramType;
    [Range(1, 4)] public int maxRamSlot;
    [Range(1, 4)] public int maxGpuSlot;
    [Range(2, 5)] public float cpuSpeed;

    public Motherboard()
    {

    }
    public Motherboard(string modelName,string manufacturer, float malfunctionRate, float cost, int maxRamSlot, RAM.RAMType ramType, int cpuSpeed, bool isMantadory) : base(modelName, manufacturer, malfunctionRate, cost)
    {
        this.ramType = ramType;
        this.maxRamSlot = maxRamSlot;
        this.cpuSpeed = cpuSpeed;
    }
}
