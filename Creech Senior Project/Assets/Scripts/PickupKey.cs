using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{

    public Component doorcollider;
    public GameObject keygone;



    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.K))
            doorcollider.GetComponent<BoxCollider>().enabled = true;


        if (Input.GetKey(KeyCode.K))
            keygone.SetActive(false);
    }
}
