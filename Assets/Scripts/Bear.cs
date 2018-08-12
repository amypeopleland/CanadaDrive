using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour {

    public Transform target;
    public GameObject bearToMove;
    public float speed;
    bool startMove = false;
    public Vector3 curPos=new Vector3();
    
    void Start()
    {
        speed = Random.Range(5, 20);
        curPos = bearToMove.transform.position;
    }
    void Update()
    {
        bearToMove.transform.position = Vector3.Lerp(curPos, target.transform.position, Mathf.PingPong(Time.time, 1));
        if (startMove)
            {
                //float step = speed * Time.deltaTime;
                //bearToMove.transform.position = Vector3.MoveTowards(bearToMove.transform.position, target.position, step);
                bearToMove.transform.position = Vector3.Lerp(curPos, target.transform.position, Mathf.PingPong(Time.time, 1));
        }


    }

    public void startMoving()
    {
        startMove = true;

    }

}
