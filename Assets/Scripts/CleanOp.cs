using TMPro;
using UnityEngine;

public class CleanOp : MonoBehaviour
{
    public GameObject a, b, c, d;
    private void OnDisable()
    {
        b.GetComponent<TMP_InputField>().text = "";
        //GameObject.Find("remText").SetActive(false);
        //c.SetActive(false);
        c.GetComponent<TMP_Text>().text = "";
        
        //a.SetActive(false);
    }
    private void OnEnable()
    {
        a.SetActive(false);
        b.SetActive(true);
        b.GetComponent<TMP_InputField>().ActivateInputField();
        c.SetActive(false);
        for (int i = 0; i < d.transform.childCount; ++i)
        {
            GameObject abc = d.transform.GetChild(i).gameObject;
            try
            {
                abc.SetActive(false);
            }
            catch { }
        }
    }
}
