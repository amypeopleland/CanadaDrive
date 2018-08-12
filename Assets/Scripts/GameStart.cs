using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;
public class GameStart : MonoBehaviour {

    public GameObject ShowTimeCount;
    public ShowTimeInGame STI=new ShowTimeInGame();
    
    FileStream fs1, fsl_1;
    StreamWriter writeFile, writeUDPDataFile;
    public GameObject CanadaNum;
    public GameObject TotalHit;
    // Use this for initialization
    void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.name== "StartLind")
        {
            ShowTimeCount.GetComponent<CountDown>().StartTheGameTimeCounting();

        }
        if(other.name== "FinishLine")
        {
            writeFileTime(false);
            //string finishTime = ShowTimeCount.GetComponent<CountDown>().GetTimeFinish();
            //if (!File.Exists(@"DebugLog.txt"))
            //{
            //    fs1 = new FileStream(@"DebugLog.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
            //    writeFile = new StreamWriter(fs1);
            //    writeFile.WriteLine(finishTime);//开始写入值


            //    writeFile.Close();
            //    fs1.Close();
            //}
            //else
            //{
            //    fs1 = new FileStream(@"DebugLog.txt", FileMode.Open, FileAccess.Write);
            //    writeFile = new StreamWriter(fs1);
            //    writeFile.WriteLine(finishTime);

            //    writeFile.Close();
            //    fs1.Close();
            //    //writeFile.WriteLine("Great" + "\n " + "askjdfhlakjshdf");//开始写入值
            //    //writeFile.WriteLine("Great" + "\n " + "askjdfhlakjshdf");//开始写入值

            //}




            //STI.ShowTime(timeText);
            
        }
    }

    public void writeFileTime(bool FailTheGame)
    {
		Debug.Log (FailTheGame);
       
        if (FailTheGame)
        {
			Application.LoadLevel(7);

            

        }
        else
        {
            string finishTime = ShowTimeCount.GetComponent<CountDown>().GetTimeFinish();
            if (!File.Exists(@"DebugLog.txt"))
            {
                fs1 = new FileStream(@"DebugLog.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                writeFile = new StreamWriter(fs1);
				writeFile.WriteLine(finishTime + ";" + CanadaNum.GetComponent<Text>().text+";"+ TotalHit.GetComponent<HitControlManager>().HitAddNum.ToString());
                writeFile.WriteLine("END");

                writeFile.Close();
                fs1.Close();
            }
            else
            {
                fs1 = new FileStream(@"DebugLog.txt", FileMode.Open, FileAccess.Write);
                writeFile = new StreamWriter(fs1);
				writeFile.WriteLine(finishTime + ";" + CanadaNum.GetComponent<Text>().text+ ";"+TotalHit.GetComponent<HitControlManager>().HitAddNum.ToString());
                writeFile.WriteLine("END");
                


                writeFile.Close();
                fs1.Close();
                //writeFile.WriteLine("Great" + "\n " + "askjdfhlakjshdf");//开始写入值
                //writeFile.WriteLine("Great" + "\n " + "askjdfhlakjshdf");//开始写入值

            }
            Application.LoadLevel(6);
        }
        
    }
}
