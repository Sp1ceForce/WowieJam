using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuController : MonoBehaviour
{
    public static MenuController Instance { get; private set; }
    public UnityEvent OnMenuStart;
    public UnityEvent OnMenuExit;

    [SerializeField] GameObject menuPanel;
    private void Start()
    {
        SetupInstance();
        Cursor.visible = false;
    }

    private void SetupInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("More than one MenuController!");
        }
    }

    public void PauseGame()
    {
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
    public void UnpauseGame()
    {
        Cursor.visible = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale==1 && Input.GetButtonDown("MenuButton"))
        {
            OpenMenu();
        }
        else if(Time.timeScale==0 && Input.GetButtonDown("MenuButton") && menuPanel.activeSelf)
        {
            CloseMenu();
        }
    }
    
    private void OpenMenu()
    {
        OnMenuStart?.Invoke();
        PauseGame();
        menuPanel.SetActive(true);
    }

    public void CloseMenu()
    {
        OnMenuExit?.Invoke();
        UnpauseGame();
        menuPanel.SetActive(false);
    }
}
