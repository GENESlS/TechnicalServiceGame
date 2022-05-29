using UnityEngine;

public class TimePassed : MonoBehaviour
{
    public GameObject a, b;

    private void WakeyWakey()
    {
        this.gameObject.SetActive(false);
        a.GetComponent<Dialog>().Normalize(true);
        //c.SetActive(true);        
        if (b.GetComponent<NonStopTimer>().enabled)
        {
            b.GetComponent<NonStopTimer>().SettimeLeft(b.GetComponent<NonStopTimer>().GettimeLeft() - 60);
        }
    }
}
