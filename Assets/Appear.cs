using UnityEngine.UI;
using UnityEngine;

public class Appear : MonoBehaviour
{
    private static float t;
    private float timeLeft = 60;
    public GameObject a,b,c,d;

    private void OnDisable()
    {
        t = timeLeft;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            if (a.activeSelf == true) 
            {
                if (b.activeSelf == false)
                {
                    this.gameObject.GetComponent<Image>().enabled = true;
                    c.SetActive(true);
                    d.SetActive(true);
                }
            } else { this.gameObject.SetActive(false); }
        }
    }
}
