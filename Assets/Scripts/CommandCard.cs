using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
public class CommandCard : MonoBehaviour,IBeginDragHandler,IEndDragHandler, IDragHandler
{
    
    public bool DroppedOnSlot;
    [SerializeField] float alphaOnDrag=0.6f;
    public AICommand Command;
    CanvasGroup canvasGroup;
    TMP_Text text;
    Canvas canvas;
    private RectTransform rectTransform;
    Vector3 startPosition = Vector3.zero;
    public void Init()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
        text = GetComponentInChildren<TMP_Text>();
        text.text = Command.Name;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        ExectuionSlot exectuionSlot = GetComponentInParent<ExectuionSlot>();
        if (exectuionSlot != null)
        {
            exectuionSlot.RemoveCommand(this);
        }
        DroppedOnSlot = false;
        canvasGroup.alpha = alphaOnDrag;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
        StartCoroutine("CheckForEndDrag");
    }
    IEnumerator CheckForEndDrag()
    {
        yield return new WaitForEndOfFrame();
        if(!DroppedOnSlot) rectTransform.localPosition = startPosition;
    }


}
