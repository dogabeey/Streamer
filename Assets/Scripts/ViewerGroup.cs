using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ViewerGroup : MonoBehaviour
{
    public enum Trait
    {
        HypeChaser, // Tends to watch popular games more.
        FameFollower, // Tends to watch more crowded streams.
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
    public List<GameType> favoriteGames;
    public List<AudioClip> favoriteSongs;
    public Stream.PlayStyle favStyle;
    
    public List<Trait> traits;

    public ViewerGroup(string groupName, int population, List<GameType> favoriteGames, List<AudioClip> favoriteSongs, Stream.PlayStyle favStyle, int traitCount)
    {
        this.groupName = groupName;
        this.population = population;
        this.favoriteGames = favoriteGames;
        this.favoriteSongs = favoriteSongs;
        this.favStyle = favStyle;
        this.traits = traits;
    }

    public void AddRandomTraits(int count)
    {
        Array a = Enum.GetValues(typeof(Trait));
        for (int i = 0; i < count; i++)
        {
            object v = a.GetValue(Mathf.RoundToInt(UnityEngine.Random.value * (a.Length - 1)));
            traits.Add((Trait)v);
        }
    }
}
