using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : MonoBehaviour {

    public GameObject busspawner;
    

	// Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            busspawner.GetComponent<busSpawner>().enabled = true;
        }
    }
    

}
