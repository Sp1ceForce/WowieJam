using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandsSlot : MonoBehaviour
{
    [SerializeField] AvailableCommandsList availableCommandsList;
    [SerializeField] List<AICommand> commands;
    [SerializeField] CommandCard card;

    public void ResetCards()
    {
        if(availableCommandsList == null)
        {
        availableCommandsList = FindObjectOfType<AvailableCommandsList>();
        }
        commands = availableCommandsList.AvailableCommands;
        KillChildren();
        foreach (var command in commands)
        {
            var newCard = Instantiate(card, transform);
            newCard.Command = command;
            newCard.Init();
        }
    }
    public void KillChildren()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Destroy(child.gameObject);
        }
    }
}
