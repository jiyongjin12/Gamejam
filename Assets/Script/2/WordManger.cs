using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WordManger : MonoBehaviour
{
    public List<Word> words;

    // WordSpawner ��ũ��Ʈ�� ������ ����
    public WordSpawner wordSpawner;

    // �Է��� ���� TMP_InputField
    public TMP_InputField inputField;

    public AudioClip popSound;
    AudioSource aS;
    SpriteRenderer effect_sr;
    Coroutine fadeOutCoroutine;

    private bool hasActiveWord;
    private Word activeWord;

    public GameObject effect;

    public int stageInt = 1;

    private bool isFade;
    
    public Count count;


    public Level level;
    public float ExpNum;

    private void Start()
    {
        aS = GetComponent<AudioSource>();
        effect_sr = effect.GetComponent<SpriteRenderer>();

        // ���� �� 3���� �ܾ �߰��մϴ�.
        AddWord();
        AddWord();
        AddWord();

        // InputField�� OnEndEdit �̺�Ʈ�� WordCheck �Լ��� �����մϴ�.
        inputField.onEndEdit.AddListener(WordCheck);
        effect.SetActive(false);
    }

    private void Update()
    {

    }

    // ���ο� �ܾ �߰��ϴ� �Լ�
    public void AddWord()
    {
        // ���� �ܾ �����Ͽ� Word ��ü�� �����ϰ�, WordSpawner�� �̿��Ͽ� ȭ�鿡 �ܾ �����մϴ�.
        Word word = new Word(WordGenerator.GetRandomWord(stageInt), wordSpawner.SpawnWord());
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
                if (fadeOutCoroutine != null)
                    StopCoroutine(fadeOutCoroutine);
                fadeOutCoroutine = StartCoroutine(FadeOut());
                aS.PlayOneShot(popSound); Debug.Log("PlaySound");

                float gainedExperience = ExpNum;
                level.SetExperience(gainedExperience);

                count.UpCount();
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

    IEnumerator FadeOut()
    {
        isFade = true;
        effect.SetActive(true);
        float fadeCount = 1;
        while (fadeCount > 0)
        {
            fadeCount -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            effect_sr.color = new Color(255/255f, 255/255f, 200/255f, fadeCount);
            isFade = false;
        }
        yield return null;
        isFade = false;
    }
}
