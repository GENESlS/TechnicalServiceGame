using System.Collections;
using UnityEngine;

public class CheckCable : MonoBehaviour
{
    Animator c;
    public GameObject d, e, f;

    private void Start()
    {
        c = GetComponent<Animator>();
    }

    public void Cable(bool isDone)
    {
        if (isDone)
        {
            StartCoroutine(TransitionBack());
            e.SetActive(false);
        }
        else 
        {
            StartCoroutine(Transition());
            d.SetActive(false);
        }

    }

    IEnumerator TransitionBack()
    {
        c.Play("rightToNormal");
        yield return new WaitForSeconds(1);
        d.SetActive(true);
        f.SetActive(true);
    }

    IEnumerator Transition()
    {
        c.Play("leanRight");
        yield return new WaitForSeconds(1);
        e.SetActive(true);
    }
}
