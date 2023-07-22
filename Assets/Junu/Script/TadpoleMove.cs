using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TadpoleMove : MonoBehaviour
{
    public Sprite[] tadPole_Row_Sprite;
    public Sprite[] tadPole_Mid_Sprite;
    public Sprite[] tadPole_High_Sprite;

    SpriteRenderer sr;

    [SerializeField]
    int level = 1;

    public bool isSprite = true;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (level > 3) 
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
        else if (level > 7)
        {
            //뒷다리
        }
        else
        {
            //앞다리
        }

        
    }
}
