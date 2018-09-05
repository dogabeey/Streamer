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
        Manufacturer manu = new Manufacturer("ASUS", 100);
        Headphone hp = new Headphone("zenman 3600", manu, 0.1f, 20, false, 1000, 100);
        XmlParse.Serialize(hp);

        Player.players.AddRange(XmlParse.ImportAll<Player>());
        foreach (Player p in Player.players)
        {
            Debug.Log(p.name + " is " + p.profile);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
