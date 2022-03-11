using TMPro;
using UnityEngine;

public class CmdInput : MonoBehaviour
{
    public GameObject a, b, c, d, e, f, g, h, restrictedAccessObj, p1Score;
    public TMP_Text m_TextComponent;
    public int flag = 0, flag1 = 0, flag2 = 0;
    bool adminstratorPrivileges = false;
    public bool dne = false;

    private void OnEnable()
    {
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);
        f.SetActive(false);
        g.SetActive(false);

        m_TextComponent.text = "";
    }
    public void Search()
    {
        if (string.Equals(a.GetComponent<TMP_InputField>().text,"ipconfig /flushdns", System.StringComparison.CurrentCultureIgnoreCase))
        {
            b.SetActive(true);
            flag = 1;
        } 
        else if (string.Equals(a.GetComponent<TMP_InputField>().text, "ipconfig /release", System.StringComparison.CurrentCultureIgnoreCase))
        {
            c.SetActive(true);
            flag1 = 1;
        }
        else if (string.Equals(a.GetComponent<TMP_InputField>().text, "ipconfig /renew", System.StringComparison.CurrentCultureIgnoreCase))
        {
            d.SetActive(true);
            flag2 = 1;
        }
        else if (string.Equals(a.GetComponent<TMP_InputField>().text, "sfc /scannow", System.StringComparison.CurrentCultureIgnoreCase))
        {
            if(adminstratorPrivileges)
            {
                f.SetActive(true);
                if(p1Score.GetComponent<DesktopScore>().sdfasd == 1)
                {
                    dne = true;
                }
            } 
            else
            {
                g.SetActive(true);
            }
        }
        else if (string.Equals(a.GetComponent<TMP_InputField>().text, "exit", System.StringComparison.CurrentCultureIgnoreCase))
        {
            GameObject.Find("CommandPrompt").SetActive(false);
            restrictedAccessObj.SetActive(true);
            AdministratorPrivileges(false);
            h.SetActive(true);
        }
        else
        {
            e.SetActive(true);
            m_TextComponent.text = ("'"+a.GetComponent<TMP_InputField>().text+ "' is not recognized " +
                "as an internal or external command, operable program or batch file.");
        }
    }

    public void AdministratorPrivileges(bool tr)
    {
        adminstratorPrivileges = tr;
    }
}
