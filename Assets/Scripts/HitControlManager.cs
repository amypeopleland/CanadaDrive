using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HitControlManager : MonoBehaviour {
    public List<string> NotHit;
    public int HitAddNum=0;
    bool HitAdd = true;
    public int HitDieNum,HitDieNumShow;
    public GameObject endGame;
    
    public GameObject TextShow;
	// Use this for initialization
	void Start () {
        HitDieNumShow = HitDieNum;
        TextShow.GetComponent<Text>().text = HitDieNumShow.ToString();

    }
	
	// Update is called once per frame
	void Update () {
        if (HitDieNum == HitAddNum)
        {
            endGame.GetComponent<GameStart>().writeFileTime(true);
        }
		TextShow.GetComponent<Text>().text = HitAddNum.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.transform.name);
        for(int i=0;i<NotHit.Count;i++)
        {
            if(collision.transform.name==NotHit[i])
            {
                HitAdd = false;
            }

        }
        if(HitAdd)
        {
            HitAddNum++;
            HitDieNumShow--;
        }
        HitAdd = true;

    }
}
