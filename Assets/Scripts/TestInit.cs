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
        new Game(new GameType("strategy", 1, 1));
        foreach (Game g in Game.games)
        {
            Debug.Log(g.name);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InitializeData()
    {
        // Whenever a new game concept is added in xml file, insert a new string here to include them in init. progress.
        GameType.types.AddRange(XmlParse.ImportAll<GameType>());
        Manufacturer.manufacturers.AddRange(XmlParse.ImportAll<Manufacturer>());
        Game.games.AddRange(XmlParse.ImportAll<Game>());
        Player.players.AddRange(XmlParse.ImportAll<Player>());
        ViewerGroup.groups.AddRange(XmlParse.ImportAll<ViewerGroup>());
    }
}
