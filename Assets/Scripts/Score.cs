using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreValue;
    Text score;
    void Start()
    {
        ScoreValue = 0;
        score = GetComponent<Text>();
        
    }
    void Update()
    {
        score.text = "Score:" + ScoreValue;
    }
}
