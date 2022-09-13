using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEPrompt : MonoBehaviour
{
    [SerializeField] GameObject E_Prompt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        E_Prompt.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        E_Prompt.SetActive(false);
    }
}
