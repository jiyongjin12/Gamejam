using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WordInput : MonoBehaviour
{
    public WordManger wordManager;
    public TMP_InputField input;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            input.Select();
            input.ActivateInputField();
            foreach (char letter in Input.inputString)
            {
                wordManager.TypeLetter(letter);
            }
        }
    }
}
