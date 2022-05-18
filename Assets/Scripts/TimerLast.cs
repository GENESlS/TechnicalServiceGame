using UnityEngine;
using TMPro;

public class TimerLast : MonoBehaviour
{
    public GameObject TimerText, failScreen;
    public float LastMoments = 120;
    GameObject Empty;
    AudioManager Manager;
    float tempTime;

    void Start()
    {
        tempTime = LastMoments;
        Empty = GameObject.Find("AudioManager");
        Manager = Empty.GetComponent<AudioManager>();
    }

    void OnDisable()
    {
        LastMoments = tempTime;
    }

     void Update()
    {
        TimerText.GetComponent<TMP_Text>().text = ((int)LastMoments).ToString();
        LastMoments -= Time.deltaTime;
        if (LastMoments <= 0)
        {
            failScreen.SetActive(true);
            Manager.Play("Fail");
            this.enabled = false;
            Manager.StopPlaying("Theme");
        }
    }


}
