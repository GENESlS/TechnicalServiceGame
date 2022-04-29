using UnityEngine;
using System.Collections;

public class ArrivedToPC : MonoBehaviour
{
    Animator a;
    public GameObject Player, MainCamera, ActionCamera;
    Vector3 landMark = new Vector3((float)-1.24914932,(float)-0.0154354004,(float)-2.91096115);
    int flag = 0;

    void Start()
    {
        a = Player.GetComponent<Animator>();
    }
    void Update()
    {
        if (Player.GetComponent<Transform>().localPosition == landMark && flag == 0){
            a.GetComponent<RoadTrip>().enabled = false;
            StartCoroutine(First());            
            flag = 1;
            this.gameObject.SetActive(false);
        }     
    }

    IEnumerator First()
    {
        a.enabled = false; a.enabled = true;
        a.Rebind();
        a.Update(0f);
        a.Play("headLeft");
        yield return new WaitForSecondsRealtime(1);
        MainCamera.SetActive(false);
        ActionCamera.SetActive(true);
        a.Play("sitting");
        yield return new WaitForSecondsRealtime(1);
        a.Play("sitIdle");
        yield return new WaitForSecondsRealtime(1);
        a.speed = 0;
    }
}
