using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSoda : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (gameObject.GetComponent<AudioSource> ().clip.name);
		gameObject.GetComponent<AudioSource> ().Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
