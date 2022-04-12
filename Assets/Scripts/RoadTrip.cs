using System.Collections;
using UnityEngine;

public class RoadTrip : MonoBehaviour
{
    Animator a;
    public GameObject b, c, d;
    //int i;
    void Start()
    {
        a = GetComponent<Animator>();
    }

    public void roadTrip()
    {
        StartCoroutine(Ani1());
        this.GetComponent<Transform>().Rotate(0, 90,0);
        a.Play("walk");
        this.GetComponent<Transform>().Rotate(0, 90,0);
        a.Play("walk");
        a.Play("walk");
        a.Play("walk");
    }

    IEnumerator Ani1()
    {
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(true);
        a.Play("standUp");
        yield return new WaitForSecondsRealtime(1);
        this.GetComponent<Transform>().Rotate(0,-90,0);
        a.Play("walk");
    }
}
