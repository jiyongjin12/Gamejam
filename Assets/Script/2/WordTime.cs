using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTime : MonoBehaviour
{
    public WordManger wordManger;

    public float wordDelay = 1.5f;
    private float nextWordTime = 0f;

    public float WaitionTime;

    private void Update()
    {
        if (wordDelay > WaitionTime)
        {
            if (Time.time >= nextWordTime)
            {
                wordManger.AddWord();
                nextWordTime = Time.time + wordDelay;
                wordDelay *= .99f;
            }
        }
        else
        {
            wordDelay = WaitionTime;

            if (Time.time >= nextWordTime)
            {
                wordManger.AddWord();
                nextWordTime = Time.time + wordDelay;
                wordDelay *= .99f;
            }
                
        }
        
    }
}


//if (fallSpeed <= WaitingTime)
//{
//    fallSpeed = WaitingTime;
//}