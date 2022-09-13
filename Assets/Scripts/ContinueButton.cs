using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Continue);
    }

    void Continue()
    {
        MenuController.Instance.CloseMenu();
    }
}
