using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialItemHit : MonoBehaviour {

    public GameObject MusicPlay;
    public GameObject Bears, Moose;
    public Transform target;
    public GameObject BloodWarningObj;
    public float speed;
    public int totalHit=0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.name);
        
        if (other.tag == "Bear")
        {
            MusicPlay.GetComponent<AudioSource>().Play();
            //Debug.Log("BearM");
            // Bears.GetComponent<Bear>().startMoving();
            other.GetComponent<Bear>().startMoving();
           
        }
    

        if (other.tag == "Moose")
        {
            MusicPlay.GetComponent<AudioSource>().Play();
            //Debug.Log("MooseM");
            other.GetComponent<Moose>().startMoving();
            
        }
        if(other.tag=="BearD")
        {
            MusicPlay.GetComponent<AudioSource>().Play();
            other.gameObject.SetActive(false);
            BloodWarningObj.GetComponent<BloodWarning>().StartToBlood = true;
            totalHit++;



        }
       
    }

    
}
