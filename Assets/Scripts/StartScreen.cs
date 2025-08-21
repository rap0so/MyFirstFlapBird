using UnityEngine;

public class GameStart : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private GameObject startPanel;

    private bool started = false;

    private void Awake()
    {
        Time.timeScale = 0f; // stop the game
        if (startPanel) startPanel.SetActive(true);
    }

    private void Update()
    {
        if (!started && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        started = true;
        if (startPanel)
        {
            var fader = startPanel.GetComponent<UIFader>();
            fader.FadeOut(0.5f); // half second fade out
        }
        Time.timeScale = 1f; // resume the game
    }
}
