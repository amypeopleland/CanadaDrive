using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class RigidBodyControl : MonoBehaviour {

    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.name);
        if (other.transform.name == "Rigid1")
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX| RigidbodyConstraints.FreezeRotationZ;
        }
        if (other.transform.name == "Rigid2")
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;
            transform.rotation = Quaternion.identity;
        }
        if (other.transform.name == "Rigid3")
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationZ;
        }
        if (other.transform.name == "Rigid4")
        {
            transform.rotation = Quaternion.identity;
            rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;

        }
    }
}
