using TMPro;
using UnityEngine;

public class AdressBarEp4 : MonoBehaviour
{
    TMP_InputField m_InputField;
    string inputText;
    public GameObject pages, testPage, emptyPage, emptyPageContext;
    GameObject currentPage;
    void Start()
    {
        m_InputField = GetComponent<TMP_InputField>();
    }

    public void ReturnEvent(){
        if (Input.GetKeyDown(KeyCode.Return))
            {
                CheckBar();
            }
    }

    public void GetText()
    {
        inputText = m_InputField.text;
    }

    public void CheckBar()
    {
        m_InputField.text = "";
        FindCurrent();
        Debug.Log(inputText);
        //if ((string.Equals(inputText.Trim(), "https://www.jobsafety.com/workplace-safety-test/14Apgs35​"))) 
          if ((string.Equals(inputText.Trim(), "https://www.jobsafety.com/workplace-safety-test/14Apgs35")))      
                {
                    currentPage.SetActive(false);
                    testPage.SetActive(true);
                } else {
                    emptyPageContext.GetComponent<TMP_Text>().text = "<b>" + inputText + "</b> " +
                                                                     "adresindeki sayfa geçici olarak " + 
                                                                     "kullanım dışı veya kalıcı olarak " +
                                                                     "yeni bir adrese taşınmış olabilir.";
                    currentPage.SetActive(false);
                    emptyPage.SetActive(true);
                }
    }

    private void FindCurrent()
    {
        for (int i = 0; i < pages.transform.childCount; i++)
        {
            if (pages.transform.GetChild(i).gameObject.activeSelf) 
                currentPage = pages.transform.GetChild(i).gameObject;
        }
    }
}
