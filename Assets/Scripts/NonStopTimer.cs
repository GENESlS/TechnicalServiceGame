using UnityEngine;
using TMPro;

public class NonStopTimer : MonoBehaviour
{
    //float t;
    public GameObject indText;
    public bool disableBckgrSound;
    private static float timeLeft = 180;
    public GameObject failScreen, a, b, c, d, e, f, g, h;
    GameObject xz;
    AudioManager aa;
    //int flag = 0;

    public float GettimeLeft()
    {
        return timeLeft;
    }
    public void SettimeLeft(float i)
    {
        timeLeft = i;
    }

    private void Awake()
    {
       // t = timeLeft;
        xz = GameObject.Find("AudioManager");
        aa = xz.GetComponent<AudioManager>();
        // aa = GameObject.Find(AudioManager.Instantiate)
    }
    /* private void OnEnable()
    {
        timeLeft = t;
    }

    private void OnDisable()
    {
        t = timeLeft;
    } */
    void Update()
    {
        indText.GetComponent<TMP_Text>().text = ((int)timeLeft).ToString();
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            a.SetActive(false); b.SetActive(false); c.SetActive(false); d.SetActive(false); e.SetActive(false);
            f.SetActive(false); g.SetActive(false); h.SetActive(false);
            failScreen.SetActive(true);
            aa.Play("Fail");
            this.enabled = false;
            if (disableBckgrSound) aa.StopPlaying("Theme");
        }
    }

    public void Reset(){
        timeLeft = 180;
    }
}
