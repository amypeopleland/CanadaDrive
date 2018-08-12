using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {


   
    //whether the car started to move or not
    public bool StartMoving = false;
    public float acc, reduceAcc;//加减速的加速度
    public float Xspeed;
    public GameObject ShowTheSpeed;
    public float hitBackOffNum;
    public GameObject particleEffectSpark;
    public bool startToBrake = false;
    public GameObject MusicHit;
    // Use this for initialization
    void Start () {
        

    }
    bool UpArrowHolding = false, startToSlowDownForward=false;

    public float SpeedForward;

    public bool hitStart = false;
    // Update is called once per frame
    void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * Xspeed;
        ShowTheSpeed.GetComponent<SpeedText>().ShowSpeed(SpeedForward);
        transform.Rotate(0, x, 0);
      //if collision then stop
        if(!hitStart)
        {
            if(!startToBrake)
            {
                if (Input.GetKeyUp(KeyCode.UpArrow))
                {
                    UpArrowHolding = false;
                    if (SpeedForward >= 0)
                    {
                        startToSlowDownForward = true;
                    }


                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    startToSlowDownForward = false;
                    UpArrowHolding = true;
                }
            }
           
            if (Input.GetKeyDown("space"))
            {
                startToBrake = true;
               
                print("space key was pressed");
            }
        }
        else if(hitStart)
        {
            
            SpeedForward=SlowDown(SpeedForward);
            if (SpeedForward <= 0)
            {
                hitStart = false;

            }
           
        }
        if (Input.GetKeyUp("space"))
        {
          
            startToBrake = false;
        }

        if (startToBrake)
        {
            if (SpeedForward >= 0)
            {
                SpeedForward = SlowDown(SpeedForward);
            }
            
        }
         if(UpArrowHolding)
        {
            //Debug.Log("ACC!");
            SpeedForward = AccForward(SpeedForward);
        }
         if(startToSlowDownForward)
        {
            if (SpeedForward >=0)
            {
                SpeedForward = SlowDown(SpeedForward);
            }
            else
            {
                startToSlowDownForward = false;
            }
        }
         
        


    }
    //acc when moving forward
    float AccForward(float speedForward)
    {
        speedForward = speedForward + acc * Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * speedForward);
        return speedForward;
    }

    float SlowDown(float speed)
    {
        if(hitStart)
        {
            speed = speed - 100 * Time.deltaTime;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else
        {
            speed = speed - reduceAcc * Time.deltaTime;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
       
        
        return speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.transform.name);
        if(collision.transform.tag=="Block")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - hitBackOffNum);
            particleEffectSpark.GetComponent<ParticleEffectPlay>().StartToPlaySpecialEffect();
            hitStart = true;
            MusicHit.GetComponent<AudioSource>().Play();
        }
       
        // transform.Translate(Vector3.forward * 0*Time.deltaTime);
       
    }
    
   





}
