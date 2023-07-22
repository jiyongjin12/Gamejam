using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordDisplay : MonoBehaviour
{
    public TMP_Text text;
    public float fallSpeed = 1f;

    [SerializeField]PlayerHp pHP;

    public int damage = 10;
    
    private string word;

    private void Start()
    {
        Invoke("DestroyText", 11);
    }

    public void Setword(string word)
    {
        text.text = word;
    }

    void DestroyText()
    {
        Debug.Log("111");
        if (pHP != null)
        {
            Debug.Log("11");
            pHP.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    public void RemoveLetter()
    {
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(-fallSpeed * Time.deltaTime, 0f, 0f);
    }


    public void SetWord(string newWord)
    {
        word = newWord;
        GetComponent<Text>().text = word;
    }

    public string GetWord()
    {
        return word;
    }
}
