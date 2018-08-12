using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
    public float tiltAroundZ;
    bool keyDownR = false;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            keyDownR = true;
            
            Debug.Log("Right");

            
        }
        if (keyDownR)
        {
            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
            Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
    }
}
