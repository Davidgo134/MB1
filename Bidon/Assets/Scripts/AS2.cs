using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AS2 : MonoBehaviour
{
     [SerializeField] private Behaviour FirstPersonController;
    
    void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.CompareTag("Player")) 
                {
                   //FirstPersonController.enabled = false;
                   //Invoke("StopPlayer", 5f);
        }
    }
     
        void StopPlayer()
 
        {
          FirstPersonController.enabled = true;
        }
}