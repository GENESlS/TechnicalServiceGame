using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEp4 : MonoBehaviour
{
    public GameObject GameManager, UIInfo, VictoryScreen;
    GameObject x;
    AudioManager y;

    private void Start()
    {
        x = GameObject.Find("AudioManager");
        y = x.GetComponent<AudioManager>();
    }
    public void Checker()
    {
        GameManager.SetActive(false);
        UIInfo.SetActive(false);
        VictoryScreen.SetActive(true);
        y.StopPlaying("Theme");
        y.Play("Success");
    }
}
