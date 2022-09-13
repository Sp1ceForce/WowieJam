using UnityEngine;
using UnityEngine.UI;

public class OpenPanelButton : MonoBehaviour
{
    [SerializeField] GameObject panel;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(()=> { panel.SetActive(true); });
    }
}
