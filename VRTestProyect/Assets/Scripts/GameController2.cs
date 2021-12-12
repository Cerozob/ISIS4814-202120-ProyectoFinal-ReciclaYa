using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController2 : MonoBehaviour {
    public enum GameState { Idle, Playing, Ended };
    public GameState gameState = GameState.Idle;
    public GameObject title;
    public GameObject targetGenerator;
    public float scaleTime = 15f;
    public float scaleInc = .10f;
    public GameObject score;
    public Text pointsText;
    private int points = 0;
    public Text recordText;
    // Use this for initialization
    void Start () {
        recordText.text = "BEST: " + GetMaxScore().ToString();
	}
	
	// Update is called once per frame
	void Update () {
        //Game starts
        if (gameState == GameState.Idle && Input.GetMouseButtonDown(0))
        {
            gameState = GameState.Playing;
            title.SetActive(false);
            score.SetActive(true);
            targetGenerator.SendMessage("StartGenerator");
            InvokeRepeating("GameTimeScale", scaleTime, scaleTime);
        }
        //Game running
        else if (gameState == GameState.Ended)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RestartGame();
            }
        }
    }

    public void RestartGame()
    {
        CancelInvoke("GameTimeScale");
        Time.timeScale = 1f;
        Debug.Log("RHYTM DOWN: " + Time.timeScale.ToString());
        SceneManager.LoadScene("MainScene");
    }
    
    void GameTimeScale()
    {
        Time.timeScale += scaleInc;
        Debug.Log("RHYTM UP: " + Time.timeScale.ToString());
    }

    public void IncreasePoints()
    {
        pointsText.text = (++points).ToString();
        if(points >= GetMaxScore()){
            recordText.text = "BEST: " + points.ToString();
            SaveScoreFirstPlace(points);
        }
    }

    public int GetMaxScore()
    {
        return PlayerPrefs.GetInt("Max Points", 0);
    }
    public void SaveScoreFirstPlace(int points)
    {
        PlayerPrefs.SetInt("Max Points", points);
    }
}
