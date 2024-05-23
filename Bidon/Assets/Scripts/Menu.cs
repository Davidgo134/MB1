using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject Meny;
    public GameObject Mask;
    public GameObject Set;
    public void Mena()
    {
     Meny.SetActive(true);
     Mask.SetActive(true);
     Set.SetActive(false);
     Time.timeScale = 0;
    }
}
