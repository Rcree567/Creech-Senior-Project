using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerHealth playerHealth;

    public float healthBonus = 10f;

   

    


    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }
    private void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            if (playerHealth.health < playerHealth.maxHealth)
            {

                playerHealth.health = playerHealth.health + healthBonus;
                
                Destroy(gameObject);

            }
        }
    }

}
