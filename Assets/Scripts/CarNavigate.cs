using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarNavigate : MonoBehaviour {
    public Transform target;
    NavMeshAgent agent;
    public float speed;
    // Use this for initialization
    void Start () {
        agent= gameObject.GetComponent<NavMeshAgent>();
        agent.speed = speed;

    }
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
	}
}
