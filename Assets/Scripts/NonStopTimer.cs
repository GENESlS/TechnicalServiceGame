using UnityEngine;
using TMPro;

public class NonStopTimer : MonoBehaviour
{
    float t;
    public GameObject indText;
    public bool disableBckgrSound;
    public float timeLeft = 40;
    public GameObject failScreen;
    GameObject xz;
    AudioManager aa;
    //int flag = 0;

    private void Awake()
    {
        t = timeLeft;
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
            failScreen.SetActive(true);
            aa.Play("Fail");
            this.enabled = false;
            if (disableBckgrSound) aa.StopPlaying("Theme");
        }
    }
}
