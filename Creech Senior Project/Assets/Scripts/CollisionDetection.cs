using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public WeaponController wp;
    public GameObject[]Enemies;


    private void OnTrigger(Collider other)
    {
        if(other.gameObject.CompareTag("Enemies"))
        {
            Destroy(other.gameObject);
            
        }
    }
}
