using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class CheckEp2 : MonoBehaviour
{
    public GameObject a, b, d, e, f;
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
        if (a.GetComponent<CheckCoding>().Check())
        {
            b.GetComponent<Image>().sprite = c;
            StartCoroutine(Asd());
        }
    }

    private IEnumerator Asd()
    {
        e.SetActive(false);
        f.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        d.SetActive(true);
        y.StopPlaying("Theme");
        y.Play("Success");
    }
}
