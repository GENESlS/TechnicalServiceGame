using TMPro;
using UnityEngine;

public class HonorPoint : MonoBehaviour
{
    private int point = 100;
    public GameObject pointText, failScreen, Game;
    Animator aa;
    TMP_Text tMP_Text;
    GameObject Empty;
    AudioManager Manager;
    float time;

    private void Start()
    {
        aa = pointText.GetComponent<Animator>();
        tMP_Text = pointText.GetComponent<TMP_Text>();
        Empty = GameObject.Find("AudioManager");
        Manager = Empty.GetComponent<AudioManager>();
    }

    private void Update()
    {
        time += Time.deltaTime;
        tMP_Text.text = point.ToString();

        if (Game.activeSelf) 
            {
                if ((int)time %4 == 0) 
                {
                    Decrease(2);
                    time++;
                }
                /*do
                    {
                        if ((int)time % 2 == 0)
                        {       
                            Decrease(1);
                        }
                        break;
                    }
                while( (int)time / 1 == (float)time ); */
            }

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
