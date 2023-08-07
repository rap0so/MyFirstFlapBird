using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1;
    float timer = 0;
    public float heightOffset = 4;

    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        RepeatSpawn();
    }

    /// <summary>
    /// When the Game is on the second of spawnRate it spawns the pipe
    /// </summary>
    void RepeatSpawn()
    {

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime; // <- seconds based on FPS
        }
        else
        {
            Spawn();
            timer = 0;
        }
    }

    void Spawn()
    {
        float lowestPipePoint = transform.position.y - heightOffset;
        float highestPipePoint = transform.position.y + heightOffset;

        var pipePosition = new Vector3(transform.position.x, Random.Range(lowestPipePoint, highestPipePoint));
        Debug.Log("pipePosition " + pipePosition);


        // we're instantiating the pipe itself, in the same position, and in the same rotation
        Instantiate(pipe, pipePosition, transform.rotation);
    }

}
