using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Game
{
    public static List<Game> games = new List<Game>();

    public string name;
    public GameType type;
    public float cost;
    public float popularity;

    public Game()
    {

    }
    public Game(string name, GameType type, float cost, float popularity)
    {
        this.name = name;
        this.type = type;
        this.cost = cost;
        this.popularity = popularity;
        games.Add(this);
    }

    public Game(string name, string type, float cost, float popularity)
    {
        this.name = name;
        this.type = GameType.types.Find(g => g.name == type);
        this.cost = cost;
        this.popularity = popularity;
        games.Add(this);
    }
    public Game(GameType type)
    {
        string[] randomList = File.ReadAllLines("Assets/random names/" + type.name.ToLower() + ".txt");
        name = randomList[new System.Random().Next(0, randomList.Length - 1)];
        this.type = type;
        cost = new System.Random().Next(1, 10) * 5;
        popularity = new System.Random().Next(1, 25) * 4;
        games.Add(this);
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
