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
        string example = File.ReadAllText("Assets/Scripts/XML/doga.xml");
        Player p = XmlParse.Deserialize<Player>(example);
        new Player(p.name, p.profile, p.gender, p.popularity,p.channel,p.gameSkill,p.playTime);

        foreach (Player pl in Player.players)
        {
            Debug.Log(p.name);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
