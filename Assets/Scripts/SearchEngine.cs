using TMPro;
using UnityEngine;

public class SearchEngine : MonoBehaviour
{
    TMP_InputField m_InputField;
    string inputText;
    public GameObject currentPage, targetPage1, targetPage2, targetPage3, emptyPage, emptyPageContext;

    void Start()
    {
        //Fetch the Input Field component from the GameObject
        m_InputField = GetComponent<TMP_InputField>();
    }

    public void ReturnEvent(){
        //string inputText = m_InputField.text;
        //Debug.Log("Text:" + m_InputField.text);
        if (Input.GetKeyDown(KeyCode.Return))
            {
                //Debug.Log("agagas");
                CheckSearchBar();
            }
    }

    public void GetText()
    {
        inputText = m_InputField.text;
        //Debug.Log(inputText);
    }

    public void CheckSearchBar()
    {
        m_InputField.text = "";
        if (string.Equals(inputText, "python password generator", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    this.gameObject.SetActive(false);
                    currentPage.SetActive(false);
                    targetPage1.SetActive(true);
                } else if (string.Equals(inputText, "python password generator", System.StringComparison.CurrentCultureIgnoreCase)) {

                } 
                else 
                {
                    emptyPageContext.GetComponent<TMP_Text>().text = "<b>" + inputText + "</b> " +
                                                                     "adresindeki sayfa geçici olarak " + 
                                                                     "kullanım dışı veya kalıcı olarak " +
                                                                     "yeni bir adrese taşınmış olabilir.";
                    currentPage.SetActive(false);
                    emptyPage.SetActive(true);
                }
    }
}
