using TMPro;
using UnityEngine;

public class CheckCoding : MonoBehaviour
{
    public GameObject a, b, c, d, e, f, g;

    public bool Check()
    {
        if (a.GetComponent<TMP_InputField>().text.Equals("https://maps.googleapis.com/maps/api/js"))
        {
            if (b.GetComponent<TMP_InputField>().text.Equals("submit"))
            {
                if (c.GetComponent<TMP_InputField>().text.Equals("text"))
                {
                    if (d.GetComponent<TMP_InputField>().text.Equals("post"))
                    {
                        if (e.GetComponent<TMP_InputField>().text.Equals("var"))
                        {
                            if (f.GetComponent<TMP_InputField>().text.Equals("document.getElementById"))
                            {
                                if (g.GetComponent<TMP_InputField>().text.Equals("map-canvas"))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
        }
        return false;
    }
}
