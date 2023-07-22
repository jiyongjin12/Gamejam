using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFixed : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SetScreen();
    }

    public void SetScreen()
    {
        int setWidth = 500;
        int setHeight = 800;

        Screen.SetResolution(setWidth, setHeight, false);
    }
}
