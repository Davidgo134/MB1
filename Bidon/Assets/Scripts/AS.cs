using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS : MonoBehaviour
{
    public GameObject EB;
     void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
          EB.SetActive(true);
        }
    }

    void OnTriggerExit(Collider exit)
    {
      if(exit.gameObject.CompareTag("Player"))
      {
        EB.SetActive(false);
      }
    }
}
