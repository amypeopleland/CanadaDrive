using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class CountDown : MonoBehaviour {

    public Text TimeCount;
    public float seconds, minutes,milisecond,timeCount;
    float currentTime;
    bool TimeStart = false;

	// Use this for initialization
	void Start () {

       
        TimeCount.text = "0" + ":" + "00"+":"+"00";
    }

    // Update is called once per frame
    void Update () {
        if(TimeStart)
        {
            timeCount += Time.deltaTime;
            minutes = (int)((Time.time- currentTime) / 60f);
            seconds = (int)((Time.time - currentTime) % 60f);
            milisecond = (timeCount * 100) % 100;

            TimeCount.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milisecond.ToString("00");
        }
       
		
	}
    public void StartTheGameTimeCounting()
    {
        TimeStart = true;
        currentTime = Time.time;
    }
    public string GetTimeFinish()
    {
        return TimeCount.text;
    }

}
