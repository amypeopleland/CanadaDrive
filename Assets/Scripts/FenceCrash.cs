using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceCrash : MonoBehaviour {

    // public GameObject carObj;
    // Use this for initialization
    public bool TriggerEnterFlag = false,TriggerExitFlag=false, StoneNoTriggerFlage=false,Rfence=false,Lfence=false;
    public Vector3 currentPos;
    public float LfenceNum, RfenceNum;
    public GameObject CarHitStart;
    public GameObject particleEffectSpark;
    public GameObject MusicPlay;
    void Start () {
        currentPos = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Rfence)
        {
            transform.position = new Vector3(currentPos.x- RfenceNum, currentPos.y, currentPos.z);
        }
        else if(Lfence)
        {
            transform.position = new Vector3(currentPos.x+ LfenceNum, currentPos.y, currentPos.z);
        }
        else
        {
            currentPos = new Vector3();
            currentPos = transform.position;
        }
    }
   
    //public void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.transform.tag == "Rfence")
    //    {
    //        Rfence = true;
    //        CarHitStart.GetComponent<CarController>().hitStart = true;
    //    }
           
    //    if (collision.transform.tag == "Lfence")
    //    {
    //        Lfence = true;
    //        CarHitStart.GetComponent<CarController>().hitStart = true;
    //    }
           
    //     //Debug.Log("OnCollisionEnter"+collision.transform.name);
    //}
    //public void OnCollisionExit(Collision collision)
    //{
    //    if (collision.transform.tag == "Rfence")
    //    {
    //        Rfence = false;
    //        CarHitStart.GetComponent<CarController>().hitStart = true;
    //    }
           
    //    if (collision.transform.tag == "Lfence")
    //    {
    //        Lfence = false;
    //        CarHitStart.GetComponent<CarController>().hitStart = true;
    //    }
            
    //     //Debug.Log("OnCollisionExit"+collision.transform.name);
    //}

    // I AM NOT SURE WHY THIS WORKS BUT IT FIXES THE BUGS
    public void OnCollisionStay(Collision collision)
    {
        
       
        if (collision.transform.tag == "Rfence")
        {
            MusicPlay.GetComponent<AudioSource>().Play();
            transform.position = new Vector3(currentPos.x - RfenceNum, currentPos.y, currentPos.z);
            currentPos = transform.position;
            CarHitStart.GetComponent<CarController>().hitStart = true;
            particleEffectSpark.GetComponent<ParticleEffectPlay>().FenceHitSpecialEffect();
            //Debug.Log("Rfence Stay");

        }
        else if (collision.transform.tag == "Lfence")
        {
            MusicPlay.GetComponent<AudioSource>().Play();
            transform.position = new Vector3(currentPos.x + LfenceNum, currentPos.y, currentPos.z);
            CarHitStart.GetComponent<CarController>().hitStart = true;
            currentPos = transform.position;
            particleEffectSpark.GetComponent<ParticleEffectPlay>().FenceHitSpecialEffect();
            //Debug.Log("Lfence Stay");
        }
       
    }
}
