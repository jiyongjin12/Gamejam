using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tes : MonoBehaviour
{
    //public TMP_InputField inputField; // ����� �Է��� ���� InputField
    //public List<TMP_Text> textList; // Canvas�� �ִ� Text ������Ʈ�� ����Ʈ�� �����մϴ�.

    //private void Update()
    //{
    //    // ����ڰ� ���� Ű�� ������ �Էµ� ���ڿ� ��ġ�ϴ� �ؽ�Ʈ�� ã�� ����ϴ�.
    //    if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
    //    {
    //        string userInput = inputField.text;
    //        RemoveMatchingText(userInput);
    //    }
    //}

    //private void RemoveMatchingText(string userInput)
    //{
    //    // ����� �Է°� ��ġ�ϴ� �ؽ�Ʈ�� ã�Ƽ� �����մϴ�.
    //    for (int i = textList.Count - 1; i >= 0; i--)
    //    {
    //        if (textList[i].text == userInput)
    //        {
    //            Destroy(textList[i].gameObject);
    //            textList.RemoveAt(i);
    //        }
    //    }
    //}

    public TMP_InputField inputField; // ����� �Է��� ���� InputField
    public GameObject wordPrefab; // ������ �ؽ�Ʈ ������Ʈ Prefab
    public Transform wordCanvas; // ������ �ؽ�Ʈ�� ���� Canvas

    private List<WordDisplay> textList = new List<WordDisplay>(); // ������ �ؽ�Ʈ�� ������ ����Ʈ

    private void Update()
    {
        // ����ڰ� ���� Ű�� ������ �Էµ� ���ڿ� ��ġ�ϴ� �ؽ�Ʈ�� ã�� ����ϴ�.
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string userInput = inputField.text;
            RemoveMatchingText(userInput);
        }
    }

    private void RemoveMatchingText(string userInput)
    {
        // ����� �Է°� ��ġ�ϴ� �ؽ�Ʈ�� ã�Ƽ� �����մϴ�.
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
