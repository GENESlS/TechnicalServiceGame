using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class searchBox : MonoBehaviour
{
    //public InputField asd;
    public GameObject a, b;
    public void search()
    {
        if(string.Equals(a.GetComponent<TMP_InputField>().text,"cmd",System.StringComparison.CurrentCultureIgnoreCase))
        {
            b.SetActive(true);
        }
    }
}
