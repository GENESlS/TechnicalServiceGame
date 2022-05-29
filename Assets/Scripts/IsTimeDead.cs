using UnityEngine;

public class IsTimeDead : MonoBehaviour
{
    public GameObject Timer;
    void Awake()
    {
        if (CheatCodes.NoTimer)
            Timer.SetActive(false);
    }
}
