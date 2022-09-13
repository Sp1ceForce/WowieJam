using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitButton : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ExitPanel);
    }

    private void ExitPanel()
    {
        transform.parent.gameObject.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
    }
}
