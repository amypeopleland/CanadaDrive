using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpeedText : MonoBehaviour {

    public Text SpeedShow;
	// Use this for initialization
	void Start () {
        
        SpeedShow.text = "0";


    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowSpeed(float speed)
    {

        if(speed<=0)
        {
            SpeedShow.text = "0";
        }
        else
        {
            if(speed<10)
            {
                SpeedShow.text = speed.ToString("0");
            }
            else if(speed<100)
            {
                SpeedShow.text = speed.ToString("00");
            }
            else
            {
                SpeedShow.text = speed.ToString("000");
            }
        }
        if(speed>150)
        {
            gameObject.GetComponent<Text>().color = Color.red;
        }
        else
        {
            gameObject.GetComponent<Text>().color = Color.black;
        }
       
    }
}
