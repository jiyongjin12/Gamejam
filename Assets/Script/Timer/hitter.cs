using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class hitter : MonoBehaviour
{
    public Count count;
    public TimeCheck time;
    public Image typingSpeedImage;

    private void Update()
    {
        // Ÿ��(Typing Speed) = (�ܾ��(Count) / 5) / (�����ð�(Time) / 60)
        if (time.currentValue > 0f)
        {
            float typingSpeed = (float)(count.Nomal / 5) / (time.currentValue / 60f);
            typingSpeedImage.fillAmount = typingSpeed / 50;
        }
        else
        {
            typingSpeedImage.fillAmount = 0f;
        }
    }


}
