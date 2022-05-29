using System.Collections;
using UnityEngine;

public class DesktopScore : MonoBehaviour
{
    public GameObject a, b, c, d, e, f;
    GameObject x;
    AudioManager y;
    bool done = false, done2 = false;
    public int sdfasd = 0;
    private void Start()
    {
        x = GameObject.Find("AudioManager");
        y = x.GetComponent<AudioManager>();
    }
    void Update()
    {
        if (a.activeSelf && done == false)
        {
            StartCoroutine(LateReaction());
        }

        if (done2 == false)
        {
            if (c.GetComponent<CmdInput>().flag + c.GetComponent<CmdInput>().flag1 + c.GetComponent<CmdInput>().flag2 == 3)
            {
                d.SetActive(true);
                y.Play("Success");
                done2 = true;
            }
        }
        if (sdfasd == 0)
        {
            if (/*this.gameObject.GetComponent<MinigameScore>().flag == 1 && */ done == true && done2 == true)
            {
                StartCoroutine(Later());
                f.SetActive(false);              
            }
        }
    }

    IEnumerator LateReaction()
    {
        done = true;
        yield return new WaitForSeconds(6);
        b.SetActive(true);
        y.Play("Success");
    }

    IEnumerator Later()
    {
        sdfasd = 1;
        yield return new WaitForSeconds(5);
        e.SetActive(true);
        y.Play("Success");
    }

    /* public void tc2()
     {
         {
             textBox1.GetComponent<TMP_Text>().text = "Sorun devam ediyor, " +
                                                     "cmd - ipconfig komutlarını dene.";
         }
     } */
}
