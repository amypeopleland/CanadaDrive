using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.IO;

using System;
public class ShowTimeInGame : MonoBehaviour {
    public Text totalTime;
    public Text canadaTin,totalHitNum;
    GameObject TimeFinishObj;
   
   
   
    // Use this for initialization
    void Start () {
        string s = "";
        if (File.Exists(@"DebugLog.txt"))
        {
            StreamReader r = new StreamReader(@"DebugLog.txt");
            string LoadFilePath = @"DebugLog.txt";
            string readLoadedFile;
            StreamReader srLoad = new StreamReader(LoadFilePath, System.Text.Encoding.Default);
            while ((readLoadedFile = srLoad.ReadLine()) != "END")
            {
               
                string[] parts = readLoadedFile.Split(';');
                Debug.Log(parts.Length);
                string T1 = parts[0];
                string T2 = parts[1];
    
                totalTime.text = parts[1];
                canadaTin.text = parts[0];
                totalHitNum.text = parts[2];
            }
            //s = r.ReadToEnd();
            //totalTime.text = s;



        }
       
    }
	
	// Update is called once per frame
	void Update () {
       // totalTime.text = TimeFinishObj.GetComponent<Text>().text;

    }
    public void ShowTime(string textTime)
    {
        Debug.Log(textTime);
    }
}
