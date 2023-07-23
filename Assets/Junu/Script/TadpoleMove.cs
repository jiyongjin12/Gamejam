using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TadpoleMove : MonoBehaviour
{
    public Sprite[] tadPole_Row_Sprite;
    public Sprite[] tadPole_Mid_Sprite;
    public Sprite[] tadPole_High_Sprite;

    SpriteRenderer sr;

    [SerializeField]
    //int level = 1;
    public Level lv;

    public bool isSprite = true;

    //public string Nextscen;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        if (lv.level <= 6) 
        {
            if (Input.anyKeyDown)
            {
                if (isSprite)
                {
                    sr.sprite = tadPole_Row_Sprite[1];
                    isSprite = false;
                }
                else if (!isSprite)
                {
                    sr.sprite = tadPole_Row_Sprite[0];
                    isSprite = true;
                }
            }
        }
        else if (lv.level > 20)
        {
            SceneManager.LoadScene("Title");
        }
        else
        {
            if (Input.anyKeyDown)
            {
                if (isSprite)
                {
                    sr.sprite = tadPole_Mid_Sprite[1];
                    isSprite = false;
                }
                else if (!isSprite)
                {
                    sr.sprite = tadPole_Mid_Sprite[0];
                    isSprite = true;
                }
            }
        }

        
    }
}
