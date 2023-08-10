using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject pipeSpawner;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        gameOverScreen.SetActive(true);

        // gameObject is a reference to the current object
        Destroy(gameObject);
        Destroy(pipeSpawner);
    }
}
