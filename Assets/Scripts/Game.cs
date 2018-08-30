using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    string name;
    GameType type;
    float cost;
    float popularity;

    public Game(string name, GameType type, float cost, float popularity)
    {
        this.name = name;
        this.type = type;
        this.cost = cost;
        this.popularity = popularity;
    }

    public float GetPopularity()
    {
        return popularity * type.popularityRate;
    }
    public float GetCost()
    {
        return cost * type.costRate;
    }
}
