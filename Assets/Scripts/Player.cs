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

    public string name;
    public string profile;
    public float popularity;
    public Gender gender;
}
