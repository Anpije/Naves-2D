using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;
    public Text highScoreText;
    public Button restartButton;

    private int score = 0;
    private bool isGameOver = false;

    void Start()
    {
        UpdateScoreText();
        gameOverPanel.SetActive(false);

        restartButton.onClick.AddListener(RestartGame);
    }

    void Update()
    {

    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntuación: " + score;
        }
    }

    public void GameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            gameOverPanel.SetActive(true);

            if (highScoreText != null)
            {
                highScoreText.text = "Puntuación Final: " + score;
            }

            Time.timeScale = 0f;

            if (AudioManager.instance != null)
                AudioManager.instance.PlayGameOverSound();
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}