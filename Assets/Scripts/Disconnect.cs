using UnityEngine;

public class Disconnect : MonoBehaviour
{
    float timeLeft = 2f;
    public GameObject a, b, c;

    private void OnEnable()
    {
        timeLeft = 2f;
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            this.gameObject.SetActive(false);
            a.SetActive(false);
            b.SetActive(true);
            c.SetActive(true);
            //timeLeft = 5f;
            // this.enabled = false;
        }
    }
}
