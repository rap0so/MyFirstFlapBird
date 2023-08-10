using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    void Start()
    {
    }

    void OnBecameInvisible()
    {
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }
}
