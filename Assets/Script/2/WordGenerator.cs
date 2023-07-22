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


//"테스트원", "테스트투", "테스트쓰리", "테스트포", "테스트파이브"
//"wow", "how", "yow", "yaho"