using System;
using System.Collections.Generic;
using UnityEngine;

public class AICommandsExecutor: MonoBehaviour
{
    [SerializeField] List<AICommand> commands;
    int commandIndex=0;
    Rigidbody2D rb;
    public bool isStarted = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(commands.Count>0) SetCommands(commands);
    }
    public void SetCommands(List<AICommand> newCommands)
    {
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.layer = 2;
        commands = newCommands;
        if(commands.Count>0)
        {
        commandIndex = 0;
        foreach (var command in commands)
        {
            command.Init(rb, transform);
        }
        commands[commandIndex].Start();
        commands[commandIndex].OnPatternEnd.AddListener(OnCommandEnd);
        }
        
    }

    public void FixedUpdate()
    {
        if (Time.timeScale == 0) return;
        if(commands.Count==0) return;
        if (isStarted)
        {
            commands[commandIndex].AIUpdate(Time.fixedDeltaTime);
        }
        
    }
    public void StartExecution()
    {
        isStarted = true;
    }
    public void StopExecution()
    {
        isStarted = false;
    }
    public void OnCommandEnd()
    {
        commands[commandIndex].OnPatternEnd.RemoveListener(OnCommandEnd);
        commandIndex++;
        if (commandIndex >= commands.Count) commandIndex = 0;
        commands[commandIndex].OnPatternEnd.AddListener(OnCommandEnd);
        commands[commandIndex].Start();
    }
}
