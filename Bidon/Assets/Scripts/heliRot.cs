using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliRot : MonoBehaviour
{
    public float speed;
    public GameObject HC;
    public float s;
    void Update()
    {
        transform.Rotate(0, 0, speed);
        HC.transform.Translate(s, s, 0);
    }
}
