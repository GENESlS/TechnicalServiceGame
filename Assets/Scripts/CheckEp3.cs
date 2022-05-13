using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class CheckEp3 : MonoBehaviour
{
   public GameObject GameManager, Loading, VictoryScreen, FailScreen, UIInfo;
    
    GameObject x;
    AudioManager y;

    private void Start()
    {
        x = GameObject.Find("AudioManager");
        y = x.GetComponent<AudioManager>();
    }
    public void Checker()
    {
        bool done = GameManager.GetComponent<CheckCodingEp3>().Check();
        Debug.Log(done);
        if (done)
        {
            Loading.SetActive(true);
            StartCoroutine(Asd());
        } else StartCoroutine(Asd2());
        
    }

    private IEnumerator Asd()
    {
        GameManager.SetActive(false);
        UIInfo.SetActive(false);
        //Timer.SetActive(false);
        //ChatBubble.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        VictoryScreen.SetActive(true);
        y.StopPlaying("Theme");
        y.Play("Success");
    }

    private IEnumerator Asd2()
    {
        Loading.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        FailScreen.SetActive(true);
    }
}
