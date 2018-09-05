using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Game
{
    string name;
    GameType type;
    float cost;
    float popularity;

    public Game()
    {
        
    }
    public Game(string name, GameType type, float cost, float popularity)
    {
        this.name = name;
        this.type = type;
        this.cost = cost;
        this.popularity = popularity;
    }
    public Game(GameType type, float cost, float popularity)
    {
        this.type = type;
        this.cost = cost;
        this.popularity = popularity;
        string[] randomList = File.ReadAllLines("Assets/Scripts/random names/strategy.txt");
        this.name = randomList[Mathf.RoundToInt(randomList.Length * Random.value) - 1];
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
