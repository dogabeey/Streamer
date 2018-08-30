using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill
{
    public Player player;
    public Game game;
    [Range(0, 100)] public float skill;
    public float playTime; // by minutes;
}
