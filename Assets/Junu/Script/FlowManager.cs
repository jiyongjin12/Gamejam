using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowManager : MonoBehaviour
{

    public GameObject pausePanel;
    public GameObject[] pauseEffect;

    public bool isPause;

    private void Start()
    {
        Time.timeScale = 1.0f;
        isPause = false;
        pauseEffect[0].SetActive(false); pauseEffect[1].SetActive(false);
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPause)
            {
                isPause = false;
                Time.timeScale = 1.0f;
                pausePanel.SetActive(false);
                pauseEffect[0].SetActive(false);
                pauseEffect[1].SetActive(false);
            }
            else if(!isPause)
            {
                isPause = true;
                Time.timeScale = 0;
                pausePanel.SetActive(true);
                pauseEffect[0].SetActive(true);
                pauseEffect[1].SetActive(true);
            }
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene("Stage");
    }

    void Restart()
    {
    }
}
