using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    public float Nomal = 0f;

    private void Start()
    {
        Nomal = 0f;
    }

    public void UpCount()
    {
        Nomal = Nomal + 5f;
    }
}
