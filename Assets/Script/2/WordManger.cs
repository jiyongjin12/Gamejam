using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WordManger : MonoBehaviour
{
    public List<Word> words;

    // WordSpawner 스크립트를 참조할 변수
    public WordSpawner wordSpawner;

    // 입력을 받을 TMP_InputField
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

        // 시작 시 3개의 단어를 추가합니다.
        AddWord();
        AddWord();
        AddWord();

        // InputField의 OnEndEdit 이벤트에 WordCheck 함수를 연결합니다.
        inputField.onEndEdit.AddListener(WordCheck);
        effect.SetActive(false);
    }

    private void Update()
    {

    }

    // 새로운 단어를 추가하는 함수
    public void AddWord()
    {
        // 랜덤 단어를 생성하여 Word 객체를 생성하고, WordSpawner를 이용하여 화면에 단어를 생성합니다.
        Word word = new Word(WordGenerator.GetRandomWord(stageInt), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word); // 생성된 단어를 리스트에 추가합니다.
    }

    // 사용자가 글자를 입력했을 때 호출되는 함수
    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            // 현재 진행중인 단어가 있는 경우, 다음 입력 글자와 일치하는지 확인하고, 일치하면 단어를 진행합니다.
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            // 진행중인 단어가 없는 경우, 입력된 글자와 일치하는 단어를 찾아서 진행중인 단어로 설정하고, 단어를 진행합니다.
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

        // 진행중인 단어가 있고, 해당 단어를 모두 입력했다면 해당 단어를 제거합니다.
        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            
            words.Remove(activeWord);
        }
    }

    // InputField에서 엔터를 누르면 호출되는 함수
    public void WordCheck(string inputText)
    {
        // 입력한 단어와 동일한 단어들을 제거합니다.
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

        // 리스트에서 해당 단어들을 제거합니다.
        foreach (Word word in wordsToRemove)
        {
            words.Remove(word);
            wordSpawner.RemoveWord(word); // 해당 단어를 화면에서도 제거합니다.
        }

        inputField.text = ""; // InputField의 내용을 비웁니다.
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
