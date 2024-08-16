using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // ”ничтожает игровой объект в начале игры
    void Start()
    {
        Destroy(gameObject); // ”ничтожение текущего игрового объекта
    }


}
