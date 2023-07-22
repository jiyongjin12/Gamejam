using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList_1 = { "agf", "had", "kalla", "fall", "salad", "all", "add", "ssd", "afk", "dal", "ddal", "das", "asdfg", "jk", "lalala", "kass", "gas", "haha", "glhf", "gg"};
    private static string[] wordList_2 = { "wow", "lol", "eye", "float", "red", "qwerty", "world", "doll", "hello", "pop", "hip", "floor", "flower", "spade", "worst", "girl", "loli", "toss", "kakao", "you", "helltaker", "faker", "code", "koi"};
    private static string[] wordList_3 = { "library", "on", "class", "school", "string", "void", "coroutine", "sprite", "abstract", "funtion", "public", "variable", "instance", "destroy", "singleton", "if", "switch", "pattern", "struct", "case", "return", "null", "main", "mathf", "vector"};
    private static string[] wordList_4 = { "spriterenderer", "rigidbody", "monobehaviour", "private", "collections", "generic", "gamemanager", "observer", "gameobject", "recttransform", "serializefield", "inspecter", "audiosource", "component", "backgroundmusic", "animator", "assembly", "assets", "project", "daisuki", "shader", "textmeshpro", "materials", "personal" };

    public static string GetRandomWord (int stageIndex)
    {
        int randomIndex = 0;
        string randomWord = "";
        switch (stageIndex)
        {
            case 1:
                randomIndex = Random.Range(0, wordList_1.Length);
                randomWord = wordList_1[randomIndex];
                break;
            case 2:
                randomIndex = Random.Range(0, wordList_2.Length);
                randomWord = wordList_2[randomIndex];
                break;
            case 3:
                randomIndex = Random.Range(0, wordList_3.Length);
                randomWord = wordList_3[randomIndex];
                break;
            case 4:
                randomIndex = Random.Range(0, wordList_4.Length);
                randomWord = wordList_4[randomIndex];
                break;
        }


        return randomWord;
    }
}


//"테스트원", "테스트투", "테스트쓰리", "테스트포", "테스트파이브"
//"wow", "how", "yow", "yaho"