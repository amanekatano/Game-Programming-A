using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block; // Unity側で指定されるblock prefab

    // Start is called before the first frame update
    void Start()
    {
        for (int x = -1; x <= 1; ++x) // 縦に並べる
        {
            for (int y = 0; y < 2; ++y) // 横に並べる
            {
                Instantiate(block, new Vector3(x * 3.0f, y * 2.0f, 0), Quaternion.identity);
                // blockオブジェクトを指定した位置に生成する
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
