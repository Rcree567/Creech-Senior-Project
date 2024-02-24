using System.Collections;
using System;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private void OnTriggerEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Enemies")
        {
            collision.gameObject.GetComponent<Enemies>().TakeDamage(1);
        }
    }

}
