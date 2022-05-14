using UnityEngine;

public class TimeBomb : MonoBehaviour
{
    float timeLeft = 7f;
    private void OnEnable()
    {
        timeLeft = 7f;
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            this.gameObject.SetActive(false);
            //timeLeft = 5f;
            //this.enabled = false;
        } 
    }
}
