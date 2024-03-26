using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private Transform Player;
    private float dist;
    public float moveSpeed;
    public float howclose;

    public int maxHealth = 100;
    public int Health;

    public float damage;


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
