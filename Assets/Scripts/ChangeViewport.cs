using TMPro;
using UnityEngine;

public class ChangeViewport : MonoBehaviour
{
     TMP_InputField m_InputField;

     public GameObject target;
    string inputText;
    //public GameObject pages, SearchEngine, G4AcademyPage, emptyPage, emptyPageContext;
    GameObject currentPage;
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
                Process();
            }
    }

    public void GetText()
    {
        inputText = m_InputField.text;
        //Debug.Log(inputText);
    }

    public void Process()
    {
        //m_InputField2.text = inputText;
        target.GetComponent<TMP_Text>().text = inputText;
    }
}
