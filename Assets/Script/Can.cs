using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : MonoBehaviour
{
    private static Can _instance = null;
    public static Can Instance => _instance;

    [Header("OBJ")]
    public PlayerHp hp;

    private void Awake()
    {
        _instance = this;
    }
}
