using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodWarning : MonoBehaviour {

    // Use this for initialization
    private float transparentLerpNumMax = 0.7f, transparentLerpNumMin=0.2f;
    public float t = 0.0f, tChange = 0;
    private bool add=true;
    public  bool StartToBlood = false;
    Color startColor;
    void Start () {
        startColor = gameObject.GetComponent<Renderer>().material.color;
        gameObject.GetComponent<Renderer>().material.color = new Color(startColor.r, startColor.g, startColor.b, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if(StartToBlood)
        {
            if (t > 0.7)
            {
                add = false;
            }
            if (t < 0)
            {
                add = true;
            }
            if (add)
            {
                t += 0.7f * Time.deltaTime;
            }
            else
            {
                t -= 0.7f * Time.deltaTime;
            }
            gameObject.GetComponent<Renderer>().material.color = new Color(startColor.r, startColor.g, startColor.b, t);
            StartCoroutine(BloodTime());
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(startColor.r, startColor.g, startColor.b, 0);
        }
        

    }
    IEnumerator BloodTime()
    {
        yield return new WaitForSeconds(3);
        StartToBlood = false;
    }
}
