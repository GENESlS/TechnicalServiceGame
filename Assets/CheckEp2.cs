using UnityEngine.UI;
using UnityEngine;

public class CheckEp2 : MonoBehaviour
{
    public GameObject a,b;
    public Sprite c;
    public void Checker()
    {
        if (a.GetComponent<CheckCoding>().Check())
        {
            b.GetComponent<Image>().sprite = c;
        }
    }
}
