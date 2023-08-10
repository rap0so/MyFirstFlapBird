using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // this is the real score
    private int playerScore = 0;
    // This text here is only possible because we imported UnityEngine.UI on line 4
    // it is the reference of the text component we have on unity
    public Text scoreText;

    // This ContextMenu here gives unity the power to execute this function 😊
    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = scoreToAdd + playerScore;
        scoreText.text = playerScore.ToString();
    }


    // This text here is only possible because we imported UnityEngine.SceneManagement on line 5
    public void restartGame()
    {
        Time.timeScale = 1;
        var currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

}
