using UnityEngine;

public class controlComp : MonoBehaviour
{
    private void OnEnable()
    {
        this.GetComponent<TimeBomb>().enabled = true;
    }

    private void OnDisable()
    {
        this.GetComponent<TimeBomb>().enabled = false;
    }
}
