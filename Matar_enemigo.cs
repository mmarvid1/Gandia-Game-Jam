using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar_enemigo : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
            {
            Debug.Log("w");
            }
    }
    void OnTriggerEnter(Collider other) 
    {
        
        
        if(other.CompareTag("kill_zone") )
            {
            gameObject.SetActive(false);  
            }
        
    }
}
