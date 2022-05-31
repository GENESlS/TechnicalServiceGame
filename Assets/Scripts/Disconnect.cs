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
            a.SetActive(false);
            b.SetActive(true);
            c.SetActive(true);
            this.gameObject.GetComponent<Test>().FrontPage();
            this.gameObject.SetActive(false);
            //timeLeft = 5f;
            // this.enabled = false;
        }
    }
}
