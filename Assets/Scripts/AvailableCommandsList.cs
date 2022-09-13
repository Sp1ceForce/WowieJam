using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AvailableCommandsList : MonoBehaviour
{
    [SerializeField]
    private List<AICommand> availableCommands;
    public List<AICommand> AvailableCommands { get => availableCommands; }
    public UnityEvent<AICommand> OnCommandPickup;
    public void AddCommand(AICommand command)
    {
        availableCommands.Add(command);
        OnCommandPickup?.Invoke(command);
    }
}
