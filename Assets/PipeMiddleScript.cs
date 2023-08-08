using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    // logicScriptClass of type LogicScript (this is the main class of LogicScript.cs)
    public LogicScript logicScriptClass;
    void Start()
    {
        // here we're instantiating the LogicScript.cs manually instead of drag-an-dropping
        logicScriptClass = GameObject.FindGameObjectWithTag("LogicManagerTag").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 3)
        {
            logicScriptClass.addScore(1);
        }

    }
}
