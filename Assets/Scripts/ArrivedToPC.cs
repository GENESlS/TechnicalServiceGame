using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    Animator a;
    public GameObject Player, MainCamera, ActionCamera;
    int flag = 0;

    void Start()
    {
        a = Player.GetComponent<Animator>();
    }
    void Update()
    {
        if (Player.GetComponent<Transform>().localPosition.x <= -1 && flag == 0){
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
    }
}
