using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        if(gameObject.name== "StartBtn")
        {
            Application.LoadLevel(1);
        }
        
        if(gameObject.name== "NewGame")
        {
            Application.LoadLevel(1);
        }
        if (gameObject.name == "VICTORIA")
        {
            Application.LoadLevel(2);
        }
        if (gameObject.name== "ChooseTheCar")
        {
            Application.LoadLevel(3);
        }
        if(gameObject.name== "SelectLocation")
        {
            Application.LoadLevel(4);
        }
        if(gameObject.name== "EnterTheGame")
        {
            Application.LoadLevel(5);
        }
        
        
    }
}
