using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    //public Text scoreText;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
