using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 20;
    float deadZone = -20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        MovePipes();
        RemovePipes();
    }

    void MovePipes()
    {
        moveSpeed = moveSpeed + (Time.time / 10000);
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }

    void RemovePipes()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
