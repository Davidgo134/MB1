using UnityEngine;

public class LevelControl : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject GC;
    void Awake()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
        MainMenu.SetActive(false);
        GC.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
