using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] ExectuionSlot execSlot;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(StartExecution);
    }

    private void StartExecution()
    {
        AICommandsExecutor CommandsExecutor = GameObject.FindGameObjectWithTag("Robot").GetComponent<AICommandsExecutor>();
        CommandsExecutor.SetCommands(execSlot.commands);
        CommandsExecutor.StartExecution();
    }
}
