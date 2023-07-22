using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeCheck : MonoBehaviour
{
    

    public TMP_Text countText;
    public float currentValue = 0f;

    private void Start()
    {
        currentValue = 0f;
        UpdateCountText();
    }

    private void Update()
    {
        // 1초에 1씩 증가
        currentValue += Time.deltaTime;
        UpdateCountText();
    }

    public void UpdateCountText()
    {
        countText.text = currentValue.ToString("0.0");
    }
}


