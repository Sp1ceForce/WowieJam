using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPositionHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null) return;
        eventData.pointerDrag.transform.SetParent(transform, false);
        eventData.pointerDrag.GetComponent<CommandCard>().DroppedOnSlot = true;
    }
}
