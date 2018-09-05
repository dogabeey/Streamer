using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hardware
{
    public string modelName;
    public Manufacturer manufacturer;
    [Range(0.01f, 100)] float malfunctionRate;
    public float cost;
    public bool isMantadory;

    public float prestige;

    public Hardware()
    {

    }
    public Hardware(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost,bool isMantadory)
    {
        this.modelName = modelName;
        this.manufacturer = manufacturer;
        this.malfunctionRate = malfunctionRate;
        this.cost = cost;

        prestige = (cost * Mathf.Pow(manufacturer.prestige, 2) / Mathf.Pow(malfunctionRate, 2));
    }
}
