using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealtManager : MonoBehaviour {

    public float startingHealth;
    private float currentHealth;

    public float flashLenght;
    private float flashCounter;

    private Renderer rend;
    private Color storedColor;

    public Slider healthBar;

	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;
        rend = GetComponent<Renderer>();
        storedColor = rend.material.GetColor("_Color");

        healthBar.value = CalculateHealth();
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }

        if(flashCounter > 0)
        {
            flashCounter -= Time.deltaTime;
            if(flashCounter <=0)
            {
                rend.material.SetColor("_Color", storedColor);
            }
        }
	}

    float CalculateHealth()
    {
        return currentHealth / startingHealth;
    }

    public void HurtPlayer(int damageAmount)
    {
 
        currentHealth -= damageAmount;
        healthBar.value = CalculateHealth();
        flashCounter = flashLenght;
        rend.material.SetColor("_Color", Color.red);
    }
}
