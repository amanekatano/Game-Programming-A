using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block; // Unity側で指定されるblock prefab

    // Start is called before the first frame update
    void Start()
    {
        for () // 縦に並べる
        {
            for () // 横に並べる
            {
                Instantiate(block, new Vector3(???, ???, 0), Quaternion.identity);
                // blockオブジェクトを指定した位置に生成する
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
