using TMPro;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using System.Collections;

public class CheckEp5 : MonoBehaviour
{
    public GameObject Code, appWindow, Loading, FailScreen, GameManager, UIInfo, VictoryScreen;
    string CodeText;
    string libraries = @"from tkinter import \*
import random, string
import pyperclip";
    string windowInitialize = @"root =Tk\(\)
root\.geometry\(\""800x800""\)
root\.resizable\(0,0\)
root\.title\(""PASSWORD GENERATOR""\)";
    string Label = @"heading = Label\(root, text = 'PASSWORD GENERATOR' , font ='arial 15 bold'\)\.pack\(\)
Label\(root, text ='SGT', font ='arial 15 bold'\)\.pack\(side = BOTTOM\)";
    string passLength = @"pass_label = Label\(root, text = 'PASSWORD LENGTH', font = 'arial 10 bold'\).pack\(\)
pass_len = IntVar\(\)
length = Spinbox\(root, from_ = 8, to_ = 32 , textvariable = pass_len , width = 15\)\.pack\(\)";
    string generatePassword = @"pass_str = StringVar\(\)
def Generator\(\):
    password = ''
    for x in range \(0,4\):
        password = random\.choice\(string\.ascii_uppercase\)\+random\.choice\(string\.ascii_lowercase\)\+random\.choice\(string\.digits\)\+random\.choice\(string\.punctuation\)
    for y in range\(pass_len\.get\(\)- 4\):
        password = password\+random\.choice\(string\.ascii_uppercase \+ string\.ascii_lowercase \+ string\.digits \+ string\.punctuation\)
    pass_str\.set\(password\)";
    
    string button = @"Button\(root, text = ""GENERATE PASSWORD"" , command = Generator \)\.pack\(pady= 5\)

Entry\(root , textvariable = pass_str\)\.pack\(\)";

    string copyFunction = @"def Copy_password\(\):
    pyperclip\.copy\(pass_str\.get\(\)\)

Button\(root, text = 'COPY TO CLIPBOARD', command = Copy_password\)\.pack\(pady=5\)

root\.mainloop\(\)";

    
    bool flag1 = false, flag2 = false, flag3 = false, 
    flag4 = false, flag5 = false, flag6 = false, flag7 = false;

    GameObject x;
    AudioManager y;

    private void Start()
    {
        x = GameObject.Find("AudioManager");
        y = x.GetComponent<AudioManager>();
    }

    public void CheckCoding()
    {
        CodeText = Code.GetComponent<TMP_Text>().text;
        //Debug.Log(CodeText);
        //Debug.Log(CodeText.IndexOf(libraries));

        RegexOptions options = RegexOptions.Multiline;
        
        foreach (Match m in Regex.Matches(CodeText, libraries, options))
        {
            flag1 = true;
            Debug.Log("libraries done");
        }

        foreach (Match m in Regex.Matches(CodeText, windowInitialize, options))
        {
            flag2 = true;
            Debug.Log("windowInitialize done");
        }

        foreach (Match m in Regex.Matches(CodeText, Label, options))
        {
            flag3 = true;
            Debug.Log("Label done");
        }

        foreach (Match m in Regex.Matches(CodeText, passLength, options))
        {
            flag4 = true;
            Debug.Log("passLength done");
        }

        foreach (Match m in Regex.Matches(CodeText, generatePassword, options))
        {
            flag5 = true;
            Debug.Log("generatePassword done");
        }

        foreach (Match m in Regex.Matches(CodeText, button, options))
        {
            flag6 = true;
            Debug.Log("button done");
        }

        foreach (Match m in Regex.Matches(CodeText, copyFunction, options))
        {
            flag7 = true;
            Debug.Log("copyFunction done");
        }
        

        if (flag1 && flag2 && flag3 && flag4 && flag5 && flag6 && flag7)
        {
            Debug.Log("Success");
            //this.gameObject.GetComponent<Test>().FrontPage();
            Loading.SetActive(true);
            StartCoroutine(Success());
        } else {
        Debug.Log("Fail");
        StartCoroutine(Fail()); }
    }

    private IEnumerator Success()
    {
        GameManager.SetActive(false);
        this.gameObject.GetComponent<Test3>().FrontLine();
        appWindow.SetActive(true);
        yield return new WaitForSeconds(3);
        UIInfo.SetActive(false);
        VictoryScreen.SetActive(true);
        y.StopPlaying("Theme");
        y.Play("Success");
        //this.enabled = false;
    }

    private IEnumerator Fail()
    {
        this.gameObject.GetComponent<Test>().FrontPage();
        Loading.SetActive(true);
        yield return new WaitForSeconds(3);
        this.gameObject.GetComponent<Test2>().Frontier();
        FailScreen.SetActive(true);
    }
}
