using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Score : MonoBehaviour
{
    public GameObject a, b, c, d, e;
    GameObject o;
    AudioManager p;
    bool dn = false, dn2 = false;
    // Start is called before the first frame update
    void Start()
    {
        o = GameObject.Find("AudioManager");
        p = o.GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(e.GetComponent<DesktopScore>().sdfasd == 1)
        {
            if (a.activeSelf && dn == false)
            {
                StartCoroutine(LR());
            } else if (c.GetComponent<CmdInput>().dne && !dn2)
            {
                dn2 = true;
                d.SetActive(true);
                p.Play("Success");
            }
        }
    }

    IEnumerator LR()
    {
        dn = true;
        yield return new WaitForSecondsRealtime(5);
        b.SetActive(true);
        p.Play("Success");
    }

    public void EndingSong()
    {
        p.StopPlaying("Theme");
        p.Play("Success");
    }
}
