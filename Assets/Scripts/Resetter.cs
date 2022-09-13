using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetter : MonoBehaviour
{
    [SerializeField] Transform robotStartPos;
    [SerializeField] AICommandsExecutor RobotObject;
    private void Start()
    {
        robotStartPos = GameObject.FindGameObjectWithTag("StartPos").transform;
        if (robotStartPos == null) return;
        Reset();
    }
    public void Reset()
    {
        var oldRobots = FindObjectsOfType<AICommandsExecutor>();
        if (oldRobots != null)
        {
            foreach (var robot in oldRobots)
            {
                Destroy(robot.gameObject);
            }
        }
        Instantiate(RobotObject,robotStartPos.position, Quaternion.identity);
    }
}
