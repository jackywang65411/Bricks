using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public static bool GamePaused;

    public GameObject GamePauseMenu;

    void Start()
    {
        GamePaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name == "HitTheBricks")
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Resume()
    {
        GamePauseMenu.SetActive(false);
        Time.timeScale = 1;
        GamePaused = false;
    }
    public void Pause()
    {
        GamePauseMenu.SetActive(true);
        Time.timeScale = 0;
        GamePaused = true;
    }
    public void Menu()
    {
        Time.timeScale = 1;
        GamePaused = false;
        SceneManager.LoadScene(0);
    }
    public void PlayPressed()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Scene1Loaded");
        //GameManager.Instance.GameState = GameManager.State.LevelOne;
    }



}