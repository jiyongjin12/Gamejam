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
        // 타수(Typing Speed) = (단어수(Count) / 5) / (연습시간(Time) / 60)
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
