using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    //int:����
    int integerNumber;
    //float:����(�����_�ȉ���7�ʂ܂�)
    float floatNumber;
    //double:����(�����_�ȉ���15�ʂ܂�)
    double doubleNumber;
    // char: ����(1����)
    char character;
    // string: ������
    string stringData;

    // Start is called before the first frame update
    void Start()
    {
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

    }

   
}