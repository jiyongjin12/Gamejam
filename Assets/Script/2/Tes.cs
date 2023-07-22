using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tes : MonoBehaviour
{
    //public TMP_InputField inputField; // 사용자 입력을 받을 InputField
    //public List<TMP_Text> textList; // Canvas에 있는 Text 컴포넌트를 리스트로 저장합니다.

    //private void Update()
    //{
    //    // 사용자가 엔터 키를 누르면 입력된 글자와 일치하는 텍스트를 찾아 지웁니다.
    //    if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
    //    {
    //        string userInput = inputField.text;
    //        RemoveMatchingText(userInput);
    //    }
    //}

    //private void RemoveMatchingText(string userInput)
    //{
    //    // 사용자 입력과 일치하는 텍스트를 찾아서 삭제합니다.
    //    for (int i = textList.Count - 1; i >= 0; i--)
    //    {
    //        if (textList[i].text == userInput)
    //        {
    //            Destroy(textList[i].gameObject);
    //            textList.RemoveAt(i);
    //        }
    //    }
    //}

    public TMP_InputField inputField; // 사용자 입력을 받을 InputField
    public GameObject wordPrefab; // 생성할 텍스트 오브젝트 Prefab
    public Transform wordCanvas; // 생성된 텍스트를 담을 Canvas

    private List<WordDisplay> textList = new List<WordDisplay>(); // 생성된 텍스트를 저장할 리스트

    private void Update()
    {
        // 사용자가 엔터 키를 누르면 입력된 글자와 일치하는 텍스트를 찾아 지웁니다.
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string userInput = inputField.text;
            RemoveMatchingText(userInput);
        }
    }

    private void RemoveMatchingText(string userInput)
    {
        // 사용자 입력과 일치하는 텍스트를 찾아서 삭제합니다.
        for (int i = textList.Count - 1; i >= 0; i--)
        {
            if (textList[i].GetWord() == userInput)
            {
                Destroy(textList[i].gameObject);
                textList.RemoveAt(i);
            }
        }
    }

    public WordDisplay SpawnWord()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-3f, 3f), 7f);

        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
        textList.Add(wordDisplay);

        return wordDisplay;
    }
}
