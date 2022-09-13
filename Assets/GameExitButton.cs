using UnityEngine;
using UnityEngine.UI;

public class GameExitButton : MonoBehaviour
{

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Exit);
    }

    void Exit()
    {
        Application.Quit();
    }
}
