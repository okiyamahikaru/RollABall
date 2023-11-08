using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringConcatenation : MonoBehaviour
{
    string name = "John";
    int age = 20;
    // Start is called before the first frame update
    void Start()
    {
        //
        Debug.Log("My name is John" + "I'm 20 years old.");
        Debug.Log("My name is John " + " I'm 20 years old.");       //.の後にスペースがある
        Debug.Log("My name is John" + "I'm 20 years old.");         //Iの前にスペースがある
        Debug.Log("My name is John" + " " + "I'm 20 years old.");   //スペースだけの文字列を連結している
        //変数を使用した文字列連結
        Debug.Log("My name is" + name + "." + "I'm" + age + "years old");
        // 文字列補完
        Debug.Log($"My name is {name}. I'm {age} years old.");
        // string.Format
        Debug.Log(string.Format("My name is {0}. I'm {1} years old.", name, age));



    }


}
