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

    /// <summary>
    /// Creates a totally random game with random name, type, etc... You can specify how many games you want to create.
    /// </summary>
    public Game(int gameCount = 1)
    {
        for (int i = 0; i < gameCount; i++)
        {
            type = GameType.types[new System.Random().Next(0, GameType.types.Count - 1)];
            do
            {
                string[] randomList = File.ReadAllLines("Assets/random names/" + type.name.ToLower() + ".txt");
                name = randomList[new System.Random().Next(0, randomList.Length - 1)];
            } while (games.Exists(g => g.name == name));
            cost = new System.Random().Next(1, 10) * 5;
            popularity = new System.Random().Next(1, 25) * 4;
            games.Add(this);
        }
    }

    /// <summary>
    /// Creates a game with specified parameters.
    /// </summary>
    public Game(string name, GameType type, float cost, float popularity)
    {
        this.name = name;
        this.type = type;
        this.cost = cost;
        this.popularity = popularity;
        games.Add(this);
    }

    /// <summary>
    /// Creates a game with specified parameters.
    /// </summary>
    public Game(string name, string type, float cost, float popularity)
    {
        this.name = name;
        this.type = GameType.types.Find(g => g.name == type);
        this.cost = cost;
        this.popularity = popularity;
        games.Add(this);
    }

    /// <summary>
    /// Creates a random game with certain game type. You can specify how many games you want to create.
    /// </summary>
    public Game(GameType type,int gameCount = 1)
    {
        for (int i = 0; i < gameCount; i++)
        {
            do
            {
                string[] randomList = File.ReadAllLines("Assets/random names/" + type.name.ToLower() + ".txt");
                name = randomList[new System.Random().Next(0, randomList.Length - 1)];
            } while (games.Exists(g => g.name == name));
            this.type = type;
            cost = new System.Random().Next(1, 10) * 5;
            popularity = new System.Random().Next(1, 25) * 4;
            games.Add(this);
        }
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
