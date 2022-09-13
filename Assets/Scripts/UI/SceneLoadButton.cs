using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoadButton : MonoBehaviour
{
    [SerializeField] int sceneToLoadIndex;
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }
    private void OnButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneToLoadIndex);
    }   
}
