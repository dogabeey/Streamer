using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player
{
    public static List<Player> players = new List<Player>();

    public enum Gender
    {
        male,
        female
    }

    public class Channel
    {
        public string name;
        public int totalViews;
        public bool isPremium;

        public Channel(string name, int totalViews, bool isPremium)
        {
            this.name = name;
            this.totalViews = totalViews;
            this.isPremium = isPremium;
        }

        public Channel()
        {

        }
    }

    public string name;
    public string profile;
    public float popularity;
    public Channel channel;
    public Gender gender;

    public Eppy.Tuple<Game, float> gameSkill;
    public Eppy.Tuple<Game, float> playTime; //in minutes. 

    public Player()
    {

    }

    public Player(string name, string profile, Gender gender, float popularity, Channel channel = null, Eppy.Tuple<Game,float> gameSkill = null, Eppy.Tuple<Game, float> playTime = null)
    {
        this.name = name;
        this.profile = profile;
        this.popularity = popularity;
        this.gender = gender;
        this.channel = channel;
        this.gameSkill = gameSkill;
        this.playTime = playTime;

        players.Add(this);
    }
}
