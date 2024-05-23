using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class losemen : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

   public void ToMainMenu()
    {
        Application.Quit();
    }
}
