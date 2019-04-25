using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson21 : MonoBehaviour
{
    public int n = 0;
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= n; ++i)
        {
            sum = sum + i;
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
