using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WordManger : MonoBehaviour
{
    //public List<Word> words;

    //public WordSpawner wordSpawner;

    //private bool hasActiveWord;
    //private Word activeWord;

    //private void Start()
    //{
    //    AddWord();
    //    AddWord();
    //    AddWord();
    //}

    //public void AddWord()
    //{
    //    Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
    //    Debug.Log(word.word);

    //    words.Add(word);
    //}

    //public void TypeLetter(char letter)
    //{
    //    if (hasActiveWord)
    //    {
    //        if (activeWord.GetNextLetter() == letter)
    //        {
    //            activeWord.TypeLetter();
    //        }
    //    }
    //    else
    //    {
    //        foreach (Word word in words)
    //        {
    //            if (word.GetNextLetter() == letter)
    //            {
    //                activeWord = word;
    //                hasActiveWord = true;
    //                word.TypeLetter();
    //                break;
    //            }
    //        }
    //    }

    //    if (hasActiveWord && activeWord.WordTyped())
    //    {
    //        hasActiveWord = false;
    //        words.Remove(activeWord);
    //    }
    //}

    public List<Word> words;

    // WordSpawner ��ũ��Ʈ�� ������ ����
    public WordSpawner wordSpawner;

    // �Է��� ���� TMP_InputField
    public TMP_InputField inputField;

    private bool hasActiveWord;
    private Word activeWord;

    private void Start()
    {
        // ���� �� 3���� �ܾ �߰��մϴ�.
        AddWord();
        AddWord();
        AddWord();

        // InputField�� OnEndEdit �̺�Ʈ�� WordCheck �Լ��� �����մϴ�.
        inputField.onEndEdit.AddListener(WordCheck);
    }

    private void Update()
    {

    }

    // ���ο� �ܾ �߰��ϴ� �Լ�
    public void AddWord()
    {
        // ���� �ܾ �����Ͽ� Word ��ü�� �����ϰ�, WordSpawner�� �̿��Ͽ� ȭ�鿡 �ܾ �����մϴ�.
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word); // ������ �ܾ ����Ʈ�� �߰��մϴ�.
    }

    // ����ڰ� ���ڸ� �Է����� �� ȣ��Ǵ� �Լ�
    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            // ���� �������� �ܾ �ִ� ���, ���� �Է� ���ڿ� ��ġ�ϴ��� Ȯ���ϰ�, ��ġ�ϸ� �ܾ �����մϴ�.
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            // �������� �ܾ ���� ���, �Էµ� ���ڿ� ��ġ�ϴ� �ܾ ã�Ƽ� �������� �ܾ�� �����ϰ�, �ܾ �����մϴ�.
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        // �������� �ܾ �ְ�, �ش� �ܾ ��� �Է��ߴٸ� �ش� �ܾ �����մϴ�.
        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }

    // InputField���� ���͸� ������ ȣ��Ǵ� �Լ�
    public void WordCheck(string inputText)
    {
        // �Է��� �ܾ�� ������ �ܾ���� �����մϴ�.
        List<Word> wordsToRemove = new List<Word>();
        foreach (Word word in words)
        {
            if (word.word == inputText)
            {
                wordsToRemove.Add(word);
            }
        }

        // ����Ʈ���� �ش� �ܾ���� �����մϴ�.
        foreach (Word word in wordsToRemove)
        {
            words.Remove(word);
            wordSpawner.RemoveWord(word); // �ش� �ܾ ȭ�鿡���� �����մϴ�.
        }

        inputField.text = ""; // InputField�� ������ ���ϴ�.
    }
}
