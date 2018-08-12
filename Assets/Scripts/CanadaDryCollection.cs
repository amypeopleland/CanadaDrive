using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanadaDryCollection : MonoBehaviour {

    public GameObject CanadaDryText;
    public GameObject ParticleCanadaDry;
    public GameObject CanOpen;

    // Use this for initialization
    void Start () {
		
		CanOpen.GetComponent<AudioSource>().Stop();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.name);
        if(other.transform.name== "Sedan")
        {
            CanadaDryText.GetComponent<CanadaDryCollectionManager>().addCanadaDryNum();
            ParticleCanadaDry.GetComponent<ParticleEffectPlay>().CanadaDryHitSpecialEffect();
            Destroy(gameObject);
			CanOpen.GetComponent<AudioSource>().Play();
        }

       
    }
}
