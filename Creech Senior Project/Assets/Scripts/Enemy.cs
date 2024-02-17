using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform Player;
    private float dist;
    public float moveSpeed;
    public float howclose;
    public string Name;
    






    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
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
