using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex11 : MonoBehaviour
{
    public int age = 0;
    void Start()
    {
        if (age < 3)
        {
            Debug.Log("0");
        }
        else if (age < 12)
        {
            Debug.Log(19740);
        }
        else if (age < 22 || age >= 65)
        {
            Debug.Log(15290);
        }
        else // 割引なし
        {
            Debug.Log(39390);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
