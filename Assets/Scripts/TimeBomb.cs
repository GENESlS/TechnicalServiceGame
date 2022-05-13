using UnityEngine;

public class TimeBomb : MonoBehaviour
{
    public float timeLeft = 7f;
    private float saveTime;

    private void Start()
    {
        saveTime = timeLeft;
    }
    private void OnEnable()
    {
        timeLeft = saveTime;
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            this.gameObject.SetActive(false);
            //timeLeft = 5f;
           // this.enabled = false;
        } 
    }
}
