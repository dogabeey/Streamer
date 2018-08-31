using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player
{
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

        private Channel(string name, int totalViews, bool isPremium)
        {
            this.name = name;
            this.totalViews = totalViews;
            this.isPremium = isPremium;
        }
    }

    public string name;
    public string profile;
    public float popularity;
    public Channel channel;
    public Gender gender;

    Eppy.Tuple<Game, float> gameSkill;
    Eppy.Tuple<Game, float> playTime; //in minutes. 

    public Player(string name, string profile, float popularity, Gender gender)
    {
        this.name = name;
        this.profile = profile;
        this.popularity = popularity;
        this.gender = gender;
    }

    public Channel CreateChannel(string name, int totalViews, bool isPremium)
    {
        return new Channel(name, totalViews, isPremium);
    }
}
