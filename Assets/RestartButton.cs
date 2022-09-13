using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(RestartLevel);
    }

    void RestartLevel()
    {
        MenuController.Instance.UnpauseGame();
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
        
    }
}
