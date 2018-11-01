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

    public class GameSkill
    {
        public Game game;
        public float skill;

        public GameSkill()
        {

        }

        public GameSkill(Game game, float skill)
        {
            this.game = game;
            this.skill = skill;
        }
    }

    public class PlayTime
    {
        public Game game;
        public float time; // in minutes

        public PlayTime()
        {

        }

        public PlayTime(Game game, float time)
        {
            this.game = game;
            this.time = time;
        }
    }

    public class Channel
    {
        public static List<Channel> channels = new List<Channel>();

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
    public List<GameSkill> gameSkill;
    public List<PlayTime> playTime;
    public Gender gender;

    public Player()
    {

    }

    public Player(string name, string profile, Gender gender, float popularity, Channel channel = null, List<GameSkill> gameSkill = null, List<PlayTime> playTime = null)
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
    //public Player(float popularity, Channel channel = null, List<GameSkill> gameSkill = null, List<PlayTime> playTime = null)
    //{
    //    do
    //    {
    //        string[] randomList = File.ReadAllLines("Assets/random names/" + type.name.ToLower() + ".txt");
    //        name = randomList[new System.Random().Next(0, randomList.Length - 1)];
    //    } while (games.Exists(g => g.name == name));
    //}
}
