using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destroy : MonoBehaviour
{
    void Start()
    {
        Invoke("DeleteMe", 5f); // ��������� ������� �������� ������� ����� 2 �������
    }

    // Update is called once per frame
    void DeleteMe()
    {
        Destroy(gameObject);
    }
}
