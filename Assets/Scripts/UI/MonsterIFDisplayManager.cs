using UnityEngine;

public class MonsterIFDisplayManager : MonoBehaviour
{
    [SerializeField] GameObject _defaultDisplay;
    [SerializeField] GameObject _informationPanel;

    private void Start()
    {
        _defaultDisplay.SetActive(true);
        _informationPanel.SetActive(false);
    }
    public void SwitchToInformationPanel()
    {
        _defaultDisplay.SetActive(false);
        _informationPanel.SetActive(true);
    }
    public void SwitchToDefaultPanel()
    {
        _defaultDisplay.SetActive(true);
        _informationPanel.SetActive(false);
    }
}
