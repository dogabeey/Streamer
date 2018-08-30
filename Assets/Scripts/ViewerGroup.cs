using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public GameType[] favoriteGames;
    public AudioClip[] favoriteSongs;
    public Stream.PlayStyle favStyle;
    
    public Trait[] traits;

    public ViewerGroup(string groupName, int population, GameType[] favoriteGames, AudioClip[] favoriteSongs, Stream.PlayStyle favStyle, Trait[] traits)
    {
        this.groupName = groupName;
        this.population = population;
        this.favoriteGames = favoriteGames;
        this.favoriteSongs = favoriteSongs;
        this.favStyle = favStyle;
        this.traits = traits;
    }
}
