using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject settingPanel;
    public GameObject howtoplayPanel;
    public AudioClip button_push;

    AudioSource aS;

    private void Start()
    {
        aS = GetComponent<AudioSource>();

        settingPanel.SetActive(false);
        howtoplayPanel.SetActive(false);
    }

    public void OnSetting()
    {
        aS.PlayOneShot(button_push);
        settingPanel.SetActive(true);
    }

    public void OffSetting()
    {
        aS.PlayOneShot(button_push);
        settingPanel.SetActive(false);
    }

    public void HowToPlay()
    {
        aS.PlayOneShot(button_push);
        howtoplayPanel.SetActive(true);
    }

    public void GameStart()
    {
        aS.PlayOneShot(button_push);
        SceneManager.LoadScene("Stage");
    }

    public void EndGame()
    {
        aS.PlayOneShot(button_push);
        Application.Quit();
    }
}
