using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExectuionSlot : MonoBehaviour, IDropHandler
{
    public List<AICommand> commands = new List<AICommand>();
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null) return;
        AddCommand(eventData.pointerDrag.GetComponent<CommandCard>());
    }
    public void AddCommand(CommandCard card)
    {
        commands.Add(card.Command);
    }
    public void RemoveCommand(CommandCard card)
    {
        commands.Remove(card.Command);
    }
    public void ResetCards()
    {
        commands.Clear();
        KillChildren();
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
