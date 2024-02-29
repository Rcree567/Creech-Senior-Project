using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    private Transform Player;
    private float dist;
    public float moveSpeed;
    public float howclose;

    public int maxHealth = 5;
    public int currentHealth;
    

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
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
            maxHealth -= 10;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        dist = Vector3.Distance(Player.position, transform.position);

        if (dist <= howclose)
        {
            transform.LookAt(Player);
            GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
        }

        //for melee attack 
        if (dist <= 1.5f)
        {
            //do damage
        }
    }

}
