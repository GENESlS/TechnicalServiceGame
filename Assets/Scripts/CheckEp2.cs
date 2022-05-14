using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class CheckEp2 : MonoBehaviour
{
    public GameObject GameManager, ResultPage, VictoryScreen, UIInfo, Timer, ChatBubble;
    public Sprite c;
    GameObject x;
    AudioManager y;

    private void Start()
    {
        x = GameObject.Find("AudioManager");
        y = x.GetComponent<AudioManager>();
    }
    public void Checker()
    {
        if (GameManager.GetComponent<CheckCoding>().Check())
        {
            ResultPage.GetComponent<Image>().sprite = c;
            StartCoroutine(Asd());
        }
    }

    private IEnumerator Asd()
    {
        GameManager.SetActive(false);
        UIInfo.SetActive(false);
        Timer.SetActive(false);
        ChatBubble.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        VictoryScreen.SetActive(true);
        y.StopPlaying("Theme");
        y.Play("Success");
    }
}
