using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
public GameObject LosePanel;
 void OnTriggerEnter(Collider coll)
 {
  if(coll.gameObject.CompareTag("Player"))
  {
   Time.timeScale = 0;
   LosePanel.SetActive(true);
  }
 }
}
