using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum State
    {
        GameMenu,
        LevelOne,
        Pauce,
        Gameover
    }
    public State GameState;
    public static GameManager Instance = null;
    private bool LevelOneLoaded;
    public int BrickCount;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
    }

    void Start()
    {
        LevelOneLoaded = false;
        BrickCount = 0;



    }
    void Update()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameState = State.LevelOne;
            Debug.Log("StateChangetoLevelOne");
        }
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            GameState = State.GameMenu;
            Debug.Log("StateChangetoMenu");
        }
        switch (GameState)
        {
            case State.GameMenu:
                LevelOneLoaded = false;
                BrickCount = 0;
                break;
            case State.LevelOne:
                    LoadLevelOne();
                if (BrickCount <=0)
                {
                    GameState = State.Gameover;
                }
                
                break;
            case State.Pauce:
                break;
            case State.Gameover:
                break;
        }
    }

    void LoadLevelOne()
    {
        Debug.Log("LoadLevelOne");
        if (LevelOneLoaded == false)
        { 
            for (int i = 0; i < 8; i++)
            {
                Instantiate(Resources.Load("Bricks"), new Vector3(-7 + i * 2, 3, 0), Quaternion.identity);
                BrickCount++;
            }
            LevelOneLoaded = true;
            
        }
    }

}
