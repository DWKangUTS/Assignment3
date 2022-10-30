using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager2 : MonoBehaviour
{
    int score;
    float time; 

    public Text CurrentScore;
    public Text gameTimer;
    

    // Start is called before the first frame update
    void Awake()
    {
        CurrentScore.text = "Score: 0";
    }
    
    void Start()
    {
        
    }

    public void GetScore()
    {
        score++;
        CurrentScore.text = string.Format($"Score: {score}");
    }

    // Update is called once per frame
    void Update()
    {
        
        GameTimer();
        
    }

    void GameTimer()
    {
        time += Time.deltaTime;
        TimeSpan timespan = TimeSpan.FromSeconds(time);
        /*minutes = (int)(time/60f) % 60;
        seconds = (int)(time/60f);
        miliseconds = (int)(time*1000f) % 1000;*/

        gameTimer.text = string.Format("{0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
    }
}
