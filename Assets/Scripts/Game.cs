using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[Serializable]
public class Game
{
    public static List<Game> games = new List<Game>();
    public string name;
    public string type;
    public float cost;
    public float popularity;

    public Game()
    {

    }
    /// <summary>
    /// Creates a game with specified parameters.
    /// </summary>
    public Game(string name, string type, float cost, float popularity)
    {
        this.name = name;
        this.type = type;
        this.cost = cost;
        this.popularity = popularity;
        games.Add(this);
    }
    public float GetPopularity()
    {
        return popularity * Type().popularityRate;
    }
    public float GetCost()
    {
        return cost * Type().costRate;
    }

    public GameType Type()
    {
        return GameType.types.Find(g => g.name == type);
    }
}
