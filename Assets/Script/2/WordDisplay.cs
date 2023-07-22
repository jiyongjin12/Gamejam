using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordDisplay : MonoBehaviour
{
    public TMP_Text text;
    public float fallSpeed = 1f;
    
    private string word;

    public void Setword(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        //text.text = text.text.Remove(0, 1);
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        //transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
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
