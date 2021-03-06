﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ViewerGroup : MonoBehaviour
{
    public static List<ViewerGroup> groups = new List<ViewerGroup>();

    public enum Trait
    {
        HypeChaser, // Tends to watch popular games more.
        FameFollower, // Tends to watch more popular players.
        Hipster, // Doesn't like popular games or streamers.
        Loyalist, // Hardly unsubs once subbed a channel.
        Troll, // Very likely to scare away other groups.
        Mocker, // Enjoys poor gameplay.
        ProWatcher, // Enjoys pro gameplay.
        Stalker, // Never speaks. Hardly subs.
        FemaleFollower, // Prefers to watch female streamers.
        MaleFollower, // Prefers to watch male streamers.
        Poor, // Never makes any donations.
        Rich, // Their donations are generous.
        HighEnder, // Interests in streamers with more expensive system.
        WarezFan, // Increased sub chance to players who use their favorite manufacturer.
    }

    public string groupName;
    public int population;

    // favorites
    public List<string> favoriteGames;
    public List<AudioClip> favoriteSongs;
    public Stream.PlayStyle favStyle;

    public List<Trait> traits;
    //public Eppy.Tuple<Stream, int> views;
    //public Eppy.Tuple<Player.Channel, int> subscription;

    public ViewerGroup(string groupName, int population, List<string> favoriteGames, Stream.PlayStyle favStyle, int traitCount)
    {
        this.groupName = groupName;
        this.population = population;
        this.favoriteGames = favoriteGames;
        this.favStyle = favStyle;
        AddRandomTraits(traitCount);

        groups.Add(this);
    }

    public void AddRandomTraits(int count)
    {
        Array a = Enum.GetValues(typeof(Trait));
        traits = new List<Trait>();
        for (int i = 0; i < count; i++)
        {
            object v = a.GetValue(Mathf.RoundToInt(UnityEngine.Random.value * (a.Length - 1)));
            traits.Add((Trait)v);
        }
    }

    public bool HasTrait(Trait t)
    {
        return traits.Exists(x => x == t);
    }

    public List<GameType> FavoriteGames()
    {
        List<GameType> retVal = new List<GameType>();
        foreach (string type in favoriteGames)
        {
            retVal.Add(GameType.types.Find(g => g.name == type));
        }
        return retVal;
    }
}
