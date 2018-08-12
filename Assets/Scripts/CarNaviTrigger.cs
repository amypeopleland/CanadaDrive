using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarNaviTrigger : MonoBehaviour {
    public GameObject particleEffect;
	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.transform.name=="Sedan")
        {
           
            //play effect
            particleEffect.GetComponent<ParticleEffectPlay>().CarHitSpecialEffect();
        }
       // Destroy(collision.transform.gameObject);
    }
   
}
