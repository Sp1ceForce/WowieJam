using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanelShow : MonoBehaviour
{
    public void ShowPanel()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        GetComponentInChildren<CommandsSlot>().ResetCards();
        GetComponentInChildren<ExectuionSlot>().ResetCards();
    }
}
