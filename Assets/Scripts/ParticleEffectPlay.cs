using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectPlay : MonoBehaviour {

    public GameObject FenceHitEffect, blockHitEffect,carHitEffect, CanadaDry;
	// Use this for initialization
	void Start () {
        blockHitEffect.GetComponent<ParticleSystem>().Stop();
        carHitEffect.GetComponent<ParticleSystem>().Stop();
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    public void StartToPlaySpecialEffect()
    {
        blockHitEffect.GetComponent<ParticleSystem>().Stop();
        blockHitEffect.GetComponent<ParticleSystem>().Play();
        
    }

    public void FenceHitSpecialEffect()
    {
        FenceHitEffect.GetComponent<ParticleSystem>().Stop();
        FenceHitEffect.GetComponent<ParticleSystem>().Play();
    }

    public void CarHitSpecialEffect()
    {
        carHitEffect.GetComponent<ParticleSystem>().Stop();
        carHitEffect.GetComponent<ParticleSystem>().Play();
    }
    public void CanadaDryHitSpecialEffect()
    {
        CanadaDry.GetComponent<ParticleSystem>().Stop();
        CanadaDry.GetComponent<ParticleSystem>().Play();
    }


}
