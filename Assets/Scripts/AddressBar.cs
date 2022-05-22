using TMPro;
using UnityEngine;

public class AddressBar : MonoBehaviour
{
    TMP_InputField m_InputField;
    string inputText;
    public GameObject currentPage, targetPage, emptyPage, emptyPageContext;

    public string Link;
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
                CheckBar(Link);
            }
    }

    public void GetText()
    {
        inputText = m_InputField.text;
        //Debug.Log(inputText);
    }

    /*void Update()
    {
        //Check if the Input Field is in focus and able to alter
        /*if (m_InputField.isFocused) 
        if (m_InputField.OnSubmit())
        {
            //Debug.Log("agagas");
            
        }
    }

    /*
    //Called when Input changes
    private void inputSubmitCallBack()
    {
        Debug.Log("Input Submitted");
        m_InputField.text = ""; //Clear Inputfield text
        //inputField.ActivateInputField(); Re-focus on the input field
        //inputField.Select(); Re-focus on the input field
    }

    //Called when Input is submitted
    private void inputChangedCallBack()
    {
        Debug.Log("Input Changed");
    }

    void OnEnable()
    {
        //Register InputField Events
        m_InputField.onEndEdit.AddListener(delegate { inputSubmitCallBack(); });
        m_InputField.onValueChanged.AddListener(delegate { inputChangedCallBack(); });
    }

    void OnDisable()
    {
        //Un-Register InputField Events
        m_InputField.onEndEdit.RemoveAllListeners();
        m_InputField.onValueChanged.RemoveAllListeners();
    } */

    public void CheckBar(string link)
    {
        m_InputField.text = "";
        if (string.Equals(inputText, link))
                {
                    this.gameObject.SetActive(false);
                    currentPage.SetActive(false);
                    targetPage.SetActive(true);
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
    /* void OnValueChange(string text)
    {
        Debug.Log("OnValueChange event received. New text is [" + text + "].");
        //Debug.Log(InputFieldComponent.selectionAnchorPosition + "  " + InputFieldComponent.selectionFocusPosition);
        
        /*m_TextComponent.text = string.Empty;

        for (int i = 0; i < text.Length; i++)
            m_TextComponent.text += (int)text[i] + "-"; 
    }

    void OnEndEdit(string text)
    {
        Debug.Log("OnEndEdit event received. text = [" + text + "].");
        //Debug.Log(InputFieldComponent.selectionAnchorPosition + "  " + InputFieldComponent.selectionFocusPosition);
    } */
}
