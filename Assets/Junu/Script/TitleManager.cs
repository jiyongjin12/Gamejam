using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject settingPanel;
    public GameObject howtoplayPanel;

    private void Start()
    {
        settingPanel.SetActive(false);
        howtoplayPanel.SetActive(false);
    }

    public void OnSetting()
    {
        settingPanel.SetActive(true);
    }

    public void OffSetting()
    {
        settingPanel.SetActive(false);
    }

    public void HowToPlay()
    {
        howtoplayPanel.SetActive(true);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Stage");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
