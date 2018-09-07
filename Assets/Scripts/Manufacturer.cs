﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manufacturer
{
    public static List<Manufacturer> manufacturers = new List<Manufacturer>();

    public string name;
    public float prestige;

    public Manufacturer()
    {

    }
    public Manufacturer(string name, float prestige)
    {
        this.name = name;
        this.prestige = prestige;
        manufacturers.Add(this);
    }
}