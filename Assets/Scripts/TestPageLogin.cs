using TMPro;
using UnityEngine;

public class TestPageLogin : MonoBehaviour
{
    public GameObject ID, Pass, InputZone, Questions;
    Animator a;
    TMP_InputField IDInput, PassInput;
    void Start()
    {
        a = GetComponent<Animator>();
        IDInput = ID.GetComponent<TMP_InputField>();
        PassInput = Pass.GetComponent<TMP_InputField>();
    }

    public void CheckLogin()
    {
        if (IDInput.text == "TS3788" && PassInput.text == "Coding123") 
        {
            InputZone.SetActive(false);
            Questions.SetActive(true);
        } 
        else
        { 
            a.Play("WrongID"); 
        }
    }
}
