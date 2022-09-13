using UnityEngine;
using UnityEngine.Events;

public class EnableCommandMapperScreen : MonoBehaviour
{
    bool canInteract = false;
    public UnityEvent OnConsoleEnable;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        canInteract = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        canInteract =false;
    }
    // Update is called once per frame
    void Update()
    {
        if(canInteract && Input.GetButtonDown("Interact"))
        {
            ShowPanel();
        }
    }

    private void ShowPanel()
    {
        OnConsoleEnable.Invoke();
        Time.timeScale = 0f;
        Cursor.visible = true;
        GameObject.FindGameObjectWithTag("ControlPanel").GetComponent<ControlPanelShow>().ShowPanel();
    }
}
