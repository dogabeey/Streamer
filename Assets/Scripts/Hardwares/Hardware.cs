﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class Hardware
{
    public string modelName;
    [XmlElement(Type = typeof(GameType))] public Manufacturer manufacturer;
    [Range(0.01f, 100)] float malfunctionRate;
    public float cost;
    public static bool isMantadory;

    public float prestige;

    public Hardware()
    {

    }
    public Hardware(string modelName,string manufacturer, float malfunctionRate, float cost)
    {
        this.modelName = modelName;
        this.manufacturer = Manufacturer.manufacturers.Find(m => m.name == manufacturer);
        this.malfunctionRate = malfunctionRate;
        this.cost = cost;

        prestige = (cost * Mathf.Pow(this.manufacturer.prestige, 2) / Mathf.Pow(malfunctionRate, 2));
    }
    public Hardware(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost)
    {
        this.modelName = modelName;
        this.manufacturer = manufacturer;
        this.malfunctionRate = malfunctionRate;
        this.cost = cost;

        prestige = (cost * Mathf.Pow(this.manufacturer.prestige, 2) / Mathf.Pow(malfunctionRate, 2));
    }
}
