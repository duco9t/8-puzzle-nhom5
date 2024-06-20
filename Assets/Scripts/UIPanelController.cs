using UnityEngine;
using UnityEngine.UI;

public class UIPanelController : MonoBehaviour
{
    public GameObject tutorialPanel;
    public Button tutorialButton;
    public Button quitButton;

    void Start()
    {
        tutorialPanel.SetActive(false);

        tutorialButton.onClick.AddListener(ShowPanel);
        quitButton.onClick.AddListener(HidePanel);
    }

    void ShowPanel()
    {
        tutorialPanel.SetActive(true);
    }

    void HidePanel()
    {
        tutorialPanel.SetActive(false);
    }
}
