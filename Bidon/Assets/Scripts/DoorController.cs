using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform door;
    public float openAngle = 90f;
    public float closeAngle = 0f;
    public float smoothTime = 2f;

    private Quaternion targetRotation;
    private bool isOpen = false;

    private void Start()
    {
        targetRotation = door.rotation;
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        

        door.rotation = Quaternion.Lerp(door.rotation, targetRotation, smoothTime * Time.deltaTime);
    }


    public void ox()
    {
            if (isOpen)
            {
                targetRotation = Quaternion.Euler(-90f, closeAngle, 0f);
                isOpen = false;
            }
            else
            {
                targetRotation = Quaternion.Euler(-90f, openAngle, 0f);
                isOpen = true;
            }
        }
}