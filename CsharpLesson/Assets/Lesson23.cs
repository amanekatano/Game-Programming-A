using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson23 : MonoBehaviour
{
    public int n = 0; //ユーザーが指定するインデックス
    void Start()
    {
        int[] array = new int[20];

        array[0] = 1;
        array[1] = 1;
        for (int i = 2; i < 20; ++i)
        {
            array[i] = array[i - 1] + array[i - 2];
        }

        Debug.Log(array[n]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
