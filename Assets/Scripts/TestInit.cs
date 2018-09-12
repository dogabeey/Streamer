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
        //new GameType("action", 1, 1);
        //new GameType("strategy", 1, 1);
        //new GameType("adventure", 1, 1);
        //new GameType("simulation", 1, 1);
        //new GameType("sports", 1, 1);
        //new GameType("rpg", 1, 1);
        {
            for (int i = 0; i < 10; i++)
            {
                Game g = new Game(new GameType("action", 1, 1));
                Debug.Log((g.name + " is a " + g.type.name + " game."));
            }
            for (int i = 0; i < 10; i++)
            {
                Game g = new Game(new GameType("strategy", 1, 1));
                Debug.Log((g.name + " is a " + g.type.name + " game."));
            }
            for (int i = 0; i < 10; i++)
            {
                Game g = new Game(new GameType("adventure", 1, 1));
                Debug.Log((g.name + " is a " + g.type.name + " game."));
            }
            for (int i = 0; i < 10; i++)
            {
                Game g = new Game(new GameType("simulation", 1, 1));
                Debug.Log((g.name + " is a " + g.type.name + " game."));
            }
            for (int i = 0; i < 10; i++)
            {
                Game g = new Game(new GameType("sports", 1, 1));
                Debug.Log((g.name + " is a " + g.type.name + " game."));
            }
            for (int i = 0; i < 10; i++)
            {
                Game g = new Game(new GameType("rpg", 1, 1));
                Debug.Log((g.name + " is a " + g.type.name + " game."));
            }
        } // random game initializing
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
