using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int:®”
        int integerNumber;
        //float:­”(¬”“_ˆÈ‰º‘æ7ˆÊ‚Ü‚Å)
        float floatNumber;
        //double:¬”(¬”“_ˆÈ‰º‘æ15ˆÊ‚Ü‚Å)
        double doubleNumber;
        // char: •¶š(1•¶š)
        char character;
        // string: •¶š—ñ
        string stringData;

        //‰‰K
        float number1 = 12.34f;
        int number2;
        integerNumber = 8;
        Debug.Log(integerNumber);
        floatNumber = 1.5f;
        Debug.Log(floatNumber);
        doubleNumber = 1.234567890123;
        Debug.Log(doubleNumber);
        character = 'u';
        Debug.Log(character);
        stringData = "unity";
        Debug.Log(stringData);

        //‰‰K
        Debug.Log("C:" + "Users" + "\\" + "Usemame" + "\\" + "Documents");
        number2 = (int)number1;
        //12
        Debug.Log(number2);

    }

   
}
