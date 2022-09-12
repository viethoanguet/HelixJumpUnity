using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    // [SerializeField] GameObject startGame;

    private int score;
    public Text scoreText;
    private void Awake()
    {
        instance = this;
    }
    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // public void StartGame()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    // }
}
