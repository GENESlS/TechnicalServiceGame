using TMPro;
using UnityEngine;

public class HonorPoint : MonoBehaviour
{
    private int point = 100;
    public GameObject pointText, failScreen;
    Animator aa;
    TMP_Text tMP_Text;
    GameObject Empty;
    AudioManager Manager;

    private void Start()
    {
        aa = pointText.GetComponent<Animator>();
        tMP_Text = pointText.GetComponent<TMP_Text>();
        Empty = GameObject.Find("AudioManager");
        Manager = Empty.GetComponent<AudioManager>();
    }

    private void Update()
    {
        tMP_Text.text = point.ToString();
        if (point <= 0)
        {
            failScreen.SetActive(true);
            Manager.Play("Fail");
            this.enabled = false;
            Manager.StopPlaying("Theme");
        }
    }

    public void Decrease(int a)
    {
        point -= a;
        aa.Play("Damage");
    }
}
