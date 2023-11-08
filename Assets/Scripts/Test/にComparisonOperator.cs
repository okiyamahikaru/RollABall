using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class にComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*比較演算子
        True: 真
        False: 偽
        */
        int x = 5;
        int y = 8;
        Debug.Log(x == y); // false
        Debug.Log(x != y); // true
        Debug.Log(x > y); // false
        Debug.Log(x < y); // true
        Debug.Log(x >= y); // false
        Debug.Log(x <= y); // true
        Debug.Log(x > 5); // false
        Debug.Log(x >= 5); // true
        if (x == y) // false
        {
            Debug.Log("xとyは等しいです"); // falseのため表示されない
        }
        if (x != y) // true
        {
            Debug.Log("xとyは等しくないです"); // trueのため表示される
        }

        bool trueOrFalse = (x == y); //false
        if (trueOrFalse) // false
        {
            Debug.Log("xとyは等しいです"); // falseのため表示されない
        }
        trueOrFalse = (x != y);
        if (trueOrFalse) // true
        {
            Debug.Log("xとyは等しくないです"); // trueのため表示される
        }



    }


}
