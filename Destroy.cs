using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Уничтожает игровой объект в начале игры
    void Start()
    {
        Destroy(gameObject); // Уничтожение текущего игрового объекта
    }


}
