using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H1 : MonoBehaviour
{
public GameObject HC;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("boba"))
        {
           HC.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.gameObject.CompareTag("boba"))
        {
           HC.SetActive(false);
        }
    }
}
