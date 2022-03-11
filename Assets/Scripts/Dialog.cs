using System.Collections;
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
            b.Play("Base Layer.leanLeft"/*, 0, 1*/);
            leftDialog.SetActive(true);
            Desktop.SetActive(false);
        }
    }

    public void Normalize(bool isRight)
    {
        if (isRight)
        {
            StartCoroutine(Example());
            rightDialog.SetActive(false);
            userInfo.SetActive(true);
        } else
        {
            b.Play("leftToNormal");
            leftDialog.SetActive(false);
            Desktop.SetActive(true);
        }
    }

    IEnumerator Ex2()
    {
        b.Play("Base Layer.leanRight"/*, 0, 1*/);
        yield return new WaitForSecondsRealtime(1);
        rightDialog.SetActive(true);
    }

    IEnumerator Example()
    {
        b.Play("rightToNormal");
        yield return new WaitForSecondsRealtime(1);
        Desktop.SetActive(true);
    }
}
