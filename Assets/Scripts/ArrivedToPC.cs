using UnityEngine;
using System.Collections;

public class ArrivedToPC : MonoBehaviour
{
    Animator a;
    public GameObject Player, MainCamera, ActionCamera;
    //Vector3 landMark = new Vector3((float)-1.24914932,(float)-0.0154354004,(float)-2.91096115);
    int flag = 0;

    void Start()
    {
        a = Player.GetComponent<Animator>();
    }
    void Update()
    {
        if (Player.GetComponent<Transform>().localPosition.x <= -1.15 && flag == 0){
            a.GetComponent<RoadTrip>().enabled = false;
            StartCoroutine(First());            
            flag = 1;
        }     
    }

    IEnumerator First()
    {
        a.enabled = false; a.enabled = true;
        a.Rebind();
        a.Update(0f);
        a.Play("headLeft");
        yield return new WaitForSeconds(1.5f);
        //Debug.Log("1");
        MainCamera.SetActive(false);
        ActionCamera.SetActive(true);
        //Debug.Log("2");
        a.Play("sitting");
        yield return new WaitForSeconds(1);
        //Debug.Log("3");
        a.Play("sitIdle");
        yield return new WaitForSeconds(1);
        a.speed = 0;
        this.gameObject.SetActive(false);
    }
}
