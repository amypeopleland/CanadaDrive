using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    float smoothSpeed = 0.125f;
    public float FollowSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 0, 6.5f);
    public void LateUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        
       transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
    }
}
