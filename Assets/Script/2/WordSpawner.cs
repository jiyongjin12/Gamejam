using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord()
    {
        float randomY = Random.Range(0.3f, 4.9f);
        Vector3 randomPosition = new Vector3(6f, randomY, 2.5f);

        //Debug.Log("Spawned word at position: " + randomPosition);


        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }

    public void RemoveWord(Word word)
    {
        //Destroy(word.display.gameObject);

        if (word.display != null)
        {
            Destroy(word.display.gameObject);
        }
    }
}
