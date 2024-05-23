using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HS : MonoBehaviour
{
public GameObject Player;
public Transform Tp;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
          Player.transform.position = Tp.position;
        }
    }
}
