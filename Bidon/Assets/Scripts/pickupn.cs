using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupn : MonoBehaviour
{
public GameObject Banan;
public GameObject Banans;
public GameObject Fire;
public GameObject Nuklz;
public GameObject Poco;
public GameObject Rouble;
public GameObject ap;
public GameObject fp;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Banan"))
                {
                    Destroy(hit.transform.gameObject);
                    Banans.SetActive(true);
                    Fire.SetActive(true);
                    ap.SetActive(false);
                    fp.SetActive(true);
                    
                }
                if (hit.transform.CompareTag("Nuklz"))
                {
                    Destroy(hit.transform.gameObject);
                    Poco.SetActive(true);
                }
                if (hit.transform.CompareTag("Poco"))
                {
                    Destroy(hit.transform.gameObject);
                    Rouble.SetActive(true);
                }
                if (hit.transform.CompareTag("Rouble"))
                {
                    Destroy(hit.transform.gameObject);
                    Banan.SetActive(true);

                }
            }
        }
    }
}
