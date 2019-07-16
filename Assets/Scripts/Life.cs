using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Life : MonoBehaviour
{
    public static int LifeValue;
    Text life;
    void Start()
    {
        LifeValue = 3;
        life = GetComponent<Text>();
    }


    void Update()
    {
        life.text = "life:" + LifeValue;
        if (LifeValue <= 0)
        {
            GameManager.Instance.GameState = GameManager.State.Gameover;
            Debug.Log("123");
        }
    }
}
