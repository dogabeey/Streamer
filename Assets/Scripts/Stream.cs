using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stream : MonoBehaviour
{
    public Player player;
    [Range(0, 24)] public int startHour;
    [Range(1, 4)] public int duration;

    public enum PlayStyle
    {
        Neutral,
        Angry,
        Cheerful,
        Educational,
        Humoruous,
        Pokerface,
        Somber
    }

    public Game game;
    public PlayStyle playStyle;
    public AudioClip song;

    public int views;

    public Stream(Player player, int startHour, int duration, Game game)
    {
        this.player = player;
        this.startHour = startHour;
        this.duration = duration;
        this.game = game;
    }
}
