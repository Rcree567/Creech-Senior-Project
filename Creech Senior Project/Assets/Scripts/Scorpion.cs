using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorpion : MonoBehaviour
{
    private Transform Player;

    public int maxHealth = 100;
    public int Health;

    public float damage;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        Health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Sword")
        {
            maxHealth -= 10;

            if (maxHealth <= 0)
            {
                Die();
            }

        }

    }
    void Die()
    {
        Destroy(gameObject);
    }
}
