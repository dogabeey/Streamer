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
