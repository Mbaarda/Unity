using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public float deathDistance = 0.5f;
    public float distanceAway;
    public Transform thisObject;
    public Transform target;

    private UnityEngine.AI.NavMeshAgent navComponent;

    // Use this for initialization
    void Start () {

        target = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {

        float dist = Vector3.Distance(target.position, transform.position);
        if (target)
        {
            navComponent.SetDestination(target.position);
        }
        else
        {
            if(target == null)
            {
                target = this.gameObject.GetComponent<Transform>();
            }
            else
            {
                target = GameObject.FindGameObjectWithTag("Player").transform;
            }
        }
	}
}
