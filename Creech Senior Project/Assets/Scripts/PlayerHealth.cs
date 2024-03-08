using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public Slider slider;
    public Text text;

    public float maxHealth = 100;


    public GameObject gameOverScreen;

   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        text.text = "Health :" + health;

       


    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer.Equals(6))
        {
            health = health - 10;
        }
        
        //You Have Died
        if(health <= 0)
        {
            gameOverScreen.SetActive(true);
            
            
        }
        
    }
    
}
