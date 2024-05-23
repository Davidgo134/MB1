using UnityEngine;

public class BHP : MonoBehaviour
{
    public GameObject StartPanel;

    void Update()
    {
        Invoke("DisableGameObject", 72f); // Вызываем метод DisableGameObject через ... секунд
    }

    void DisableGameObject()
    {
        StartPanel.SetActive(false); // Выключаем текущий объект
        
    }
}