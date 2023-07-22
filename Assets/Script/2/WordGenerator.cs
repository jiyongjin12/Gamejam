using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "wow", "how", "yow", "yaho", "Hay", "hi", "yem", "no"};

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}


//"�׽�Ʈ��", "�׽�Ʈ��", "�׽�Ʈ����", "�׽�Ʈ��", "�׽�Ʈ���̺�"
//"wow", "how", "yow", "yaho"