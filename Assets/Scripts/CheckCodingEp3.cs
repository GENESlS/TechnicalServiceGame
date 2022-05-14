using TMPro;
using UnityEngine;

public class CheckCodingEp3 : MonoBehaviour
{
    public GameObject a, b, c, d, e, f, g, h, i, j, k, l, m;

    public bool Check()
    {
        if (a.GetComponent<TMP_InputField>().text.Equals("DATABASE"))
        {
            if (b.GetComponent<TMP_InputField>().text.Equals("PRIMARY KEY"))
            {
                if (c.GetComponent<TMP_InputField>().text.Equals("CREATE TABLE"))
                {
                    if (d.GetComponent<TMP_InputField>().text.Equals("* FROM"))
                    {
                        if (e.GetComponent<TMP_InputField>().text.Equals("INTO"))
                        {
                            if (f.GetComponent<TMP_InputField>().text.Equals("VALUES"))
                            {
                                if (g.GetComponent<TMP_InputField>().text.Equals("WHERE"))
                                {
                                    if (h.GetComponent<TMP_InputField>().text.Equals("CREATE"))
                                    {
                                        if (i.GetComponent<TMP_InputField>().text.Equals("AS"))
                                        {
                                            if (j.GetComponent<TMP_InputField>().text.Equals("PROC"))
                                            {
                                                if (k.GetComponent<TMP_InputField>().text.Equals("EXEC"))
                                                {
                                                    if (l.GetComponent<TMP_InputField>().text.Equals("DATE()"))
                                                    {
                                                        if (m.GetComponent<TMP_InputField>().text.Equals("INNER JOIN"))
                                                        {
                                                            return true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
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
