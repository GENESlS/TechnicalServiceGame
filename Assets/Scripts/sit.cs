using UnityEngine;

public class sit : MonoBehaviour
{
    float timeLeft = 1.5f;
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft<0)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().speed = 0;
            this.enabled = false;
        }
    }
}
