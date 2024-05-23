using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBE : MonoBehaviour
{
    public GameObject xbut;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
           xbut.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
           xbut.SetActive(false);
        }
    }
}
