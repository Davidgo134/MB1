using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayPlayer : MonoBehaviour
{
public GameObject Banan;
public GameObject Fire;
public GameObject Radio;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("PickUp"))
                {
                    Destroy(hit.transform.gameObject);
                    Banan.SetActive(true);
                    Fire.SetActive(true);
                }
                if (hit.transform.CompareTag("PickUp2"))
                {
                    Destroy(hit.transform.gameObject);
                    Radio.SetActive(true);
                    Invoke("ro", 5f);
                }
            }
        }
    }
    void ro()
    {
      Radio.SetActive(false);
    }
}