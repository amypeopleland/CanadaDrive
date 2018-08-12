using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRestPos : MonoBehaviour {
    public Transform PosRest;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.transform.name);
        if(collision.transform.name== "Sedan")
        {
            collision.transform.position = new Vector3(PosRest.position.x, PosRest.position.y, PosRest.position.z);
            collision.transform.rotation = Quaternion.identity;
            collision.transform.GetComponent<CarController>().SpeedForward = 0.0f;
            
        }
        
    }
}
