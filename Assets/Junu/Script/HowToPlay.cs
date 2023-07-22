using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour
{
    public GameObject HowToPlayPanel;
    public Image info;
    public Sprite[] page;
    public int currentPage;

    void Start()
    {
        currentPage = 0;
        HowToPlayPanel.SetActive(false);
    }


    public void NextPage()
    {
        currentPage++;

        if(currentPage == 1)
        {
            info.sprite = page[0];
        }
        else if(currentPage == 2)
        {
            info.sprite = page[1];
        }
        else if (currentPage == 3)
        {
            info.sprite = page[2];
        }
        else if (currentPage == 4)
        {
            info.sprite = page[3];
        }
        else if (currentPage >= 5)
        {
            info.sprite = page[0];
            currentPage = 0;
            HowToPlayPanel.SetActive(false);
        }
    }
}
