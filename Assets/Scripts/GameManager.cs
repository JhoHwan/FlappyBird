using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    private int _score = 0;
    private int _bestScore = 0;

    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private Text _scoreText;

    public void Awake()
    {
        if(Instance == null)
            Instance = this;
        else 
            Destroy(this);
    }
    
    private void ShowGameOverPanel()
    {
        _gameOverPanel.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
    }

    public void GameOver()
    {
        PauseGame();
        ShowGameOverPanel();
    }

    public void IncreaseScore()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }
}
