using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    float timeTaken;
    public Text CurrentScore;
    public Text BestScore;
    public Text BestTime;

    private string scoreName = "BestScore";
    private string timeName = "Current Best Time";
    private int bestScore = 0;
    private float bestTime = 0f;
    public bool timerActive = true;
    // Start is called before the first frame update
    void Awake() 
    {
        bestScore = PlayerPrefs.GetInt(scoreName, 0);
        BestScore.text = $"Best Score: {bestScore.ToString()}";

        bestTime = PlayerPrefs.GetFloat(timeName, bestTime);
        BestTime.text = $"Current Best Time: {bestTime.ToString()}";
    }
    
    void Start()
    {
        
    }

    public void GetScore()
    {
        score++;
        CurrentScore.text = string.Format($"Score: {score}");

        if (score > bestScore)
        {
            PlayerPrefs.SetInt(scoreName, score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timeTaken += Time.deltaTime;
            BestTime.text = timeTaken.ToString();
        }
    }

        public void bestscoreTime()
    {
        timerActive = false;
        if (timeTaken > bestTime)
        {
            BestTime.text = timeTaken.ToString();

            PlayerPrefs.SetFloat(timeName, timeTaken);
        }
    }
}
