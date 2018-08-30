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

    public List<RAM> RAMs;
    public List<GPU> GPUs;

    public Motherboard(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, int maxRamSlot, RAM.RAMType ramType, int cpuSpeed, bool isMantadory) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {
        this.ramType = ramType;
        this.maxRamSlot = maxRamSlot;
        this.cpuSpeed = cpuSpeed;

        RAMs = new List<RAM>(maxRamSlot);
        GPUs = new List<GPU>(maxGpuSlot);
    }
}
