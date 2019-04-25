using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex21 : MonoBehaviour
{
    public int[] array = new int[20];
    void Start()
    {
        // i % 3 == 0 // 3の倍数
        // i % 10 == 3 // 1の位が3
        // i / 10 == 3
        // (i >= 30 && i <= 39) // 十の位が3

        int i = 1;
        int count = 0;
        while (count < 20)
        {
            if (i % 3 == 0 || i % 10 == 3 || i / 10 == 3)
            {
                array[count] = i;
                count++;
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
