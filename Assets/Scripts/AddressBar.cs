using TMPro;
using UnityEngine;

public class AddressBar : MonoBehaviour
{
    TMP_InputField m_InputField;
    public GameObject currentPage, targetPage, emptyPage, emptyPageContext;
    void Start()
    {
        //Fetch the Input Field component from the GameObject
        m_InputField = GetComponent<TMP_InputField>();
    }

    void Update()
    {
        //Check if the Input Field is in focus and able to alter
        if (m_InputField.isFocused)
        {
            if (Input.GetKeyDown("enter"))
            {
                if (string.Equals(m_InputField.text,
                "https://www.jobsafety.com/workplace-safety-test/14Apgs35"))
                {
                    this.enabled = false;
                    currentPage.SetActive(false);
                    targetPage.SetActive(true);
                } 
                else 
                {
                    emptyPageContext.GetComponent<TMP_Text>().text = m_InputField.text + " " +
                                                                     emptyPageContext.GetComponent<TMP_Text>().text;
                    currentPage.SetActive(false);
                    emptyPage.SetActive(true);
                }
            }
        }
    }
}
