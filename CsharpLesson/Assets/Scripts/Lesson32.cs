using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson32 : MonoBehaviour
{
    bool isMoving = false; // 移動 or 静止?
    void Start()
    {
    }

    void Update()
    {
    }

    private void OnMouseEnter()
    {
        isMoving = true;
        Debug.Log("Enter");
    }

    private void OnMouseExit()
    {
        isMoving = false;
        Debug.Log("Exit");
    }
}
