using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bidonoff : MonoBehaviour
{
public float HP;
public GameObject plane;
public GameObject player;
public Behaviour losbun;
    void OnTriggerEnter(Collider other)
      {
        if(other.gameObject.CompareTag("Bullet"))
        {
          Destroy(other.gameObject);
          HP += 1;
        }
      }

    void Update()
    {
         if(HP == 500)
        {
         losbun.enabled = false;
         plane.SetActive(true);
         player.SetActive(false);
        }
    }
      
}