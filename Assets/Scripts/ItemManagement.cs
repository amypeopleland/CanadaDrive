using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemManagement : MonoBehaviour {
    public Image ImageChange;
    public List<Sprite> currentImage;
    int num,picOne;
	// Use this for initialization
	void Start () {
        num = currentImage.Count;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowImg()
    {
        picOne = Random.Range(0, num - 1);

        ImageChange.sprite = currentImage[picOne];
    }
}
