using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static bool Paused;
    public GameObject PauseScreen;
    public GameObject pIcon;
    public GameObject upIcon;
    public void OnPause()
    {
        if(BirdScript.instance.alive)
        {
            if (Paused)
                UnPauseGame();
            else
                PauseGame();
            Paused = !Paused;
        }
    }
    void PauseGame()
    {
        PauseScreen.SetActive(true);
        upIcon.SetActive(true);
        pIcon.SetActive(false);
        Time.timeScale = 0f;
    }
    void UnPauseGame()
    {
        PauseScreen.SetActive(false);
        upIcon.SetActive(false);
        pIcon.SetActive(true);
        Time.timeScale = 1f;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            OnPause();
        }    
    }
}
