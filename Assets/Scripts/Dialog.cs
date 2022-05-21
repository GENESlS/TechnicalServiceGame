using System.Collections;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    Animator b;
    public GameObject rightDialog, Desktop, leftDialog, userInfo; //rEnd, lEnd;
    //bool directionFlag = false;

    private void Start()
    {
        b = GetComponent<Animator>();
    }
    public void Talk(bool isRight)
    {
        if (isRight)
        {
            StartCoroutine(Ex2());
            Desktop.SetActive(false);
            //directionFlag = true ;
        } else
        {
            StartCoroutine(Ex3());
            Desktop.SetActive(false);
        }
    }

    public void Normalize(bool isRight)
    {
        if (isRight)
        {
            StartCoroutine(Example());
            rightDialog.SetActive(false);
            
        } else
        {
            StartCoroutine(Example2());
            leftDialog.SetActive(false);
        }
    }

    IEnumerator Ex2()
    {
        b.Play("Base Layer.leanRight"/*, 0, 1*/);
        yield return new WaitForSecondsRealtime(1);
        rightDialog.SetActive(true);
    }

    IEnumerator Ex3()
    {
        b.Play("Base Layer.leanLeft"/*, 0, 1*/);
        yield return new WaitForSecondsRealtime(1);
        leftDialog.SetActive(true);
    }

    IEnumerator Example()
    {
        b.Play("rightToNormal");
        yield return new WaitForSecondsRealtime(1);
        Desktop.SetActive(true);
        userInfo.SetActive(true);
    }

    IEnumerator Example2()
    {
        b.Play("leftToNormal");
        yield return new WaitForSecondsRealtime(1);
        Desktop.SetActive(true);
        userInfo.SetActive(true);
    }
}
