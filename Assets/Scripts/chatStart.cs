using UnityEngine.UI;
using UnityEngine;

public class chatStart: MonoBehaviour
{
    public GameObject a, b;
    public void Transfer()
    {
        a.GetComponent<Image>().sprite = b.GetComponent<Image>().sprite;
    }
}
