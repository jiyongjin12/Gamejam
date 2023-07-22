using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public GameObject settingPanel;

    private void Start()
    {
        settingPanel.SetActive(false);
    }

    public void OnSetting()
    {
        settingPanel.SetActive(true);
    }

    public void OffSetting()
    {
        settingPanel?.SetActive(false);
    }
}
