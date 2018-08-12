using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : MonoBehaviour {

    public Transform target;
    public float speed;
    bool startMove = false;
    public GameObject MooseObj;
    void Update()
    {
        if (startMove)
        {
            //Debug.Log("HA");
            float step = speed * Time.deltaTime;
           // MooseObj.transform.position = Vector3.MoveTowards(MooseObj.transform.position, target.position, step);
        }

    }

    public void startMoving()
    {
        startMove = true;
    }
}
