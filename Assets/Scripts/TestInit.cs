using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class TestInit : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        Game g = new Game("Rise of nations",new GameType("strategy", 1, 2), 13, 12);
        Player p = new Player("Doğa Can", "A streamer", Player.Gender.male, 0, new Player.Channel("dogabeey gaming", 2135, true),new Player.GameSkill[] { new Player.GameSkill(g, 65) });
        string parse = XmlParse.Serialize(p);
        Debug.Log(parse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
