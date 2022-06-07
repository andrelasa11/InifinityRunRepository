using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    public int maxScore;

    public BananaBar bananaBar;

    private void Start()
    {
        bananaBar.SetMaxScore(maxScore);
    }

    public void AddScore()
    {
        score++;

        bananaBar.SetScore(score);

        if(score >= maxScore)
        {
            LoadScene("WinnerScene");
        }
    }

    public void DoGameOver()
    {
        score = 0;

        LoadScene("GameOverScene");
    }

    public void LoadScene (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
