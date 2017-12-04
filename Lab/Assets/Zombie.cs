using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {

    private NavMeshAgent agent;
    private Transform target;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void FixedUpdate () {
        agent.SetDestination(target.position);
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
