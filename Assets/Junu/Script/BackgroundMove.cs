using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float moveSpeed;

    public Vector2 startPoint;
    public Vector2 endPoint;

    RectTransform rtf;

    void Start()
    {
        rtf = GetComponent<RectTransform>();

        rtf.position = startPoint;
    }
    void FixedUpdate()
    {
        if (transform.position.x <= endPoint.x)
        {
            rtf.transform.position = startPoint;
        }
        else
        {
            rtf.transform.Translate(Vector2.left * moveSpeed);
        }
    }
}
