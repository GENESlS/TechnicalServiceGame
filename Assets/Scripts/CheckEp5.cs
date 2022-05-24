using TMPro;
using UnityEngine;

public class CheckEp5 : MonoBehaviour
{
    public GameObject Code;
    string CodeText;
    string libraries = "from tkinter import *\n" + 
                       "import random, string\n" +
                       "import pyperclip";
    bool flag1 = false, flag2 = false, flag3 = false, flag4 = false, flag5 = false;
    void Start()
    {
        CodeText = Code.GetComponent<TMP_Text>().text;
    }

    // Update is called once per frame
    public void CheckCoding()
    {
        //if (CodeText.Contains())
    }
}
