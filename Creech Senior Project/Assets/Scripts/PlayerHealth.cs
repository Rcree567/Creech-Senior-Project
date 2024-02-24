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

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Enemies")
            health = health - 20f;

        //game over
        if (health <= 0)
        {

           
            Destroy(this.gameObject);
        }
    }
}