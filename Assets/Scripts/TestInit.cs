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
        GameType tempType = new GameType("Template", 2, 0.2f);
        Manufacturer tempManu = new Manufacturer("Template", 72);
        Game tempGame = new Game("Template: Return of The Temp", "Template", 20, 80);
        Player tempPlayer = new Player("Tempman", "Just another temporary streamer", Player.Gender.male,1);
        ViewerGroup tempGroup = new ViewerGroup("1", 42150, new List<string> { "Template: Return of The Temp" }, Stream.PlayStyle.Educational, 4);
        XmlParse.ExportAll(GameType.types);
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
