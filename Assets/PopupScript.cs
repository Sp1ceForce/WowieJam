using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class PopupScript : MonoBehaviour
{
    [SerializeField] RectTransform startTransform;
    [SerializeField] RectTransform endTransform;
    [SerializeField] float showSpeed = 0.5f;
    [SerializeField] float showtime = 2f;
    RectTransform rectTransform;
    TMP_Text popupText;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AvailableCommandsList>().OnCommandPickup.AddListener(DisplayPopup);
        rectTransform= GetComponent<RectTransform>();   
        popupText = GetComponentInChildren<TMP_Text>();
    }

    public void DisplayPopup(AICommand command)
    {
        popupText.text = $"Acquired a \"{command.name}\" command";
        StartCoroutine("PopupCoroutine");
    }
    IEnumerator PopupCoroutine()
    {
        rectTransform.DOAnchorPos(endTransform.anchoredPosition, showSpeed);

        yield return new WaitForSeconds(showtime);
        rectTransform.DOAnchorPos(startTransform.anchoredPosition, showSpeed);
    }
}
