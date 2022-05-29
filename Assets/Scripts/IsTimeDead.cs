using UnityEngine;
using UnityEngine.SceneManagement;

public class IsTimeDead : MonoBehaviour
{
    public GameObject Timer;
    void Awake()
    {
        if (CheatCodes.NoTimer) { 
        if (SceneManager.GetActiveScene().buildIndex < 8)
        {
            Timer.GetComponent<NonStopTimer>().enabled = false;
        } else {
            Timer.GetComponent<TimerLast>().enabled = false;
        }  }
    }
}
