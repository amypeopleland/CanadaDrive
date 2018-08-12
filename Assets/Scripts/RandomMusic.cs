using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMusic : MonoBehaviour {
    public List<AudioClip> musicList;
	// Use this for initialization
	void Start () {
        int num=Random.Range(0, musicList.Count - 1);
        Debug.Log(num);
        gameObject.GetComponent<AudioSource>().clip = musicList[num];
        gameObject.GetComponent<AudioSource>().Play();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
