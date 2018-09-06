using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtGiantManager : MonoBehaviour {

    public int health;
    private int currentHealth;

    // Use this for initialization
    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += 8;
        }
    }
    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
