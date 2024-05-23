using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliCol : MonoBehaviour
{
    public GameObject Player;
     private void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.CompareTag("Player"))
        {
          Player.SetActive(false);
        }
    }
}
