using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerGroup : MonoBehaviour
{
    public string groupName;
    public int population;

    // favorites
    public GameType[] favoriteGames;
    public AudioClip[] favoriteSongs;
    public Stream.PlayStyle favStyle;

    public enum Trait
    {
        HypeChaser, // Tends to watch popular games more.
        FameFollower, // Tends to watch more crowded streams.
        Hipster, // Doesn't like popular games or streamers.
        Loyalist, // Hardly unsubs once subbed a channel.
        Troll, // Very likely to scare away other groups.
        Mocker, // Enjoys poor gameplay.
        ProWatcher, // Enjoys pro gameplay.
        Stalker // Never speaks. Hardly subs.
    }

    public List<Trait> traits;
}
