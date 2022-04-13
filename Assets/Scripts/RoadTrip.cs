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

    void Update()
    {
        if (this.gameObject.GetComponent<Transform>().position.x <= -20){
             this.gameObject.GetComponent<RoadTrip>().enabled = false;
         }
    }

    public void roadTrip()
    {
        StartCoroutine(Ani1());
        //Vector3(-20.0658417,-0.0154353976,-6.00324059);
    }

    IEnumerator Ani1()
    {
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(true);
        a.Play("standUp");
        //Debug.Log("Standing Up !!");
        yield return new WaitForSecondsRealtime(1);
        this.GetComponent<Transform>().Rotate(0 , -90, 0);
        a.Play("walk 1"); 
        yield return new WaitForSecondsRealtime(1);
        this.GetComponent<Transform>().Rotate(0, 90,0);
        a.Play("walk 2");
        yield return new WaitForSecondsRealtime(1);
        a.Play("walk 2_1");
        yield return new WaitForSecondsRealtime(1);
        this.GetComponent<Transform>().Rotate(0, 90,0);
        a.Play("walk 3");
    }
}
