using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerScript : MonoBehaviour {

    private NavMeshAgent agent;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.destination = hit.point;
            }
        }
	}
}
