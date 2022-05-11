using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class CheckEp3 : MonoBehaviour
{
   public GameObject GameManager, /*LoadingPage,*/ VictoryScreen, UIInfo;
    
    GameObject x;
    AudioManager y;

    private void Start()
    {
        x = GameObject.Find("AudioManager");
        y = x.GetComponent<AudioManager>();
    }
    public void Checker()
    {
        if (GameManager.GetComponent<CheckCodingEp3>().Check())
        {
            //LoadingPage.SetActive(true);
            StartCoroutine(Asd());
        }
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
}
