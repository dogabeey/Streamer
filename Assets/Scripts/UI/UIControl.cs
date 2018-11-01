using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public Animator anim;
	// Use this for initialization
	void Start ()
    {
        anim.Play("anim");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void NewGame()
    {

    }

    public void LoadGame()
    {

    }

    public void Options()
    {

    }

    public void Exit()
    {
        Debug.Log("çıkılıyor");
        Application.Quit();
    }

    
}
