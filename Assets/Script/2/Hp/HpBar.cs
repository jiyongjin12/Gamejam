using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    private Image healthSlider;
    public PlayerHp player;

    private void Start()
    {
        healthSlider = GetComponent<Image>();
    }

    void Update()
    {
        healthSlider.fillAmount = player.currentHp / player.maxHp;
    }
}
