using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD: MonoBehaviour
{
   [SerializeField] public GameObject Player;
    public Transform Tp;
    public Transform Tp2;
    [SerializeField] private Behaviour FirstPersonController;
    public void OH()
    {
       {
        Player.transform.position = Tp.transform.position;
        FirstPersonController.enabled = false;
        Invoke("StopPlayer", 0.1f);
       }
    }

    public void EH()
    {
        Player.transform.position = Tp2.transform.position;
        FirstPersonController.enabled = false;
        Invoke("StopPlayer", 0.1f);
    }

           void StopPlayer()
 
        {
          FirstPersonController.enabled = true;
        }
}
