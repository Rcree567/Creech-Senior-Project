using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;


   void Start()
    {
        currentHealth = maxHealth; 
    }


    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Sword")
        {
            maxHealth -= 5;
            Destroy(gameObject);
        }
    }
}
