using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public string nextSceneName;

    public void NextScen()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
