using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public float attackDistance = 3f;
    public float attackDelay = 0.4f;
    public float attackSpeed = 1f;
    public int attackDamage = 1;
    public LayerMask attackLayer;

    bool attacking = false;
    bool readyToAttack = true;
    int attackCount;


    public void Attack()
    {
        if (!readyToAttack || attacking) return;
        
        readyToAttack = false;
        attacking = true;

        Invoke(nameof(ResetAttack), attackSpeed);
        
    }

    void ResetAttack()
    {
        attacking = false;
        readyToAttack = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemies")
        {
            Destroy(other.gameObject);
        }
    }
}
