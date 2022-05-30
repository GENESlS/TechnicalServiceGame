using UnityEngine;
using UnityEngine.SceneManagement;

public class IsTimeDead : MonoBehaviour
{
    public GameObject Timer, t2;
    void Awake()
    {
        if (CheatCodes.NoTimer) { 
        if (SceneManager.GetActiveScene().buildIndex == 2)
        { Timer.SetActive(false); t2.SetActive(false); }
        else if (SceneManager.GetActiveScene().buildIndex < 8)
        { Timer.GetComponent<NonStopTimer>().enabled = false; } 
        else { Timer.GetComponent<TimerLast>().enabled = false; }  }
    }
}
