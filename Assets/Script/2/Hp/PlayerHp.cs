using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    public float maxHp = 100;
    public float currentHp;

    private void Start()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;

        if (currentHp <= 0)
        {
            Die();
        }
    }


    private void Die()
    {
        Debug.Log("아 우리 애들 보고 싶다");
        SceneManager.LoadScene("Title");
    }
}
