using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTheGame : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		StartCoroutine(LogoStart());

	}
	IEnumerator LogoStart()
	{
		yield return new WaitForSeconds(22);
		Application.LoadLevel(5);
	}
}
