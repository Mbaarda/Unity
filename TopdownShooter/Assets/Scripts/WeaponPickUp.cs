using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour {

    public GameObject myWeapon;
    public GameObject weaponOnGround;
    

	// Use this for initialization
	void Start () {
        
	}

    void OnTriggerEnter(Collider _collider)
    {

        if (_collider.gameObject.tag == "Player")
        {
            myWeapon.SetActive(false);
        }

        if (_collider.gameObject.tag == "Player")
        {
            weaponOnGround.SetActive(true);
            
        }

        if (_collider.gameObject.tag == "Player")
        {
            
        }
       
            
    }

}
