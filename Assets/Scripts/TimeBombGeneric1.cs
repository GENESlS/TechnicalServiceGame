using UnityEngine;

public class TimeBombGeneric1 : MonoBehaviour
{
    public float timeLeft = 3f;

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
