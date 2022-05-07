using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBomb : MonoBehaviour
{
    float timeLeft = 8f;

    private void OnEnable()
    {
        timeLeft = 8f;
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
