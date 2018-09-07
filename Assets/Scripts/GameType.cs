using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameType
{
    public static List<GameType> types = new List<GameType>();

    public string name;
    [Range(1, 5)] public float popularityRate;
    [Range(1, 5)] public float costRate;

    public GameType()
    {

    }
    public GameType(string name, float popularityRate, float costRate)
    {
        this.name = name;
        this.popularityRate = popularityRate;
        this.costRate = costRate;
        types.Add(this);
    }
}
