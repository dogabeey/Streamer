using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class TestInit : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        
        new GameType("action", 1, 1);
        new Game("Call of Duty", "action", 70, 40);
        new Manufacturer("Lobbytech", 90);
        new Webcam("A101 Pristine", "Lobbytech", 1.0f, 70, false);
        for (int i = 0; i < 20; i++)
        {
            new Player();
        }

        JsonParse.ExportAll(GameType.types);
        JsonParse.ExportAll(Game.games);
        JsonParse.ExportAll(Player.players);
                
        InitializeData();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InitializeData()
    {
        // Whenever a new game concept is added in xml file, insert a new string here to include them in init. progress.
    }
}
