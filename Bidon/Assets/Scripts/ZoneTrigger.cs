using UnityEngine;

public class ZoneTrigger : MonoBehaviour
{
    public GameObject objectToEnable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pd"))
        {
            objectToEnable.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pd"))
        {
            objectToEnable.SetActive(false);
        }
    }
}