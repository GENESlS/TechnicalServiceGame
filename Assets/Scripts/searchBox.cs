using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class searchBox : MonoBehaviour
{
    TMP_InputField m_InputField;
    string inputText;
    public GameObject b;
    //Sprite temp;
    public Sprite EmptySearch, cmdSearch;

    void Start()
    {
        //Fetch the Input Field component from the GameObject
        m_InputField = GetComponent<TMP_InputField>();
        //temp = this.gameObject.GetComponent<Image>().sprite;
    }

    public void ReturnEvent(){
        //string inputText = m_InputField.text;
        //Debug.Log("Text:" + m_InputField.text);
        if (Input.GetKeyDown(KeyCode.Return))
            {
                //Debug.Log("agagas");
                search();
            }
    }

    public void GetText()
    {
        inputText = m_InputField.text;
        //Debug.Log(inputText);
    }
    public void search()
    {
        m_InputField.text = "";
        m_InputField.DeactivateInputField();
        //FindCurrent();
        if (string.Equals(inputText, "cmd", System.StringComparison.CurrentCultureIgnoreCase))
            {
                b.GetComponent<Image>().sprite = cmdSearch;
                b.GetComponent<Transform>().GetChild(0).gameObject.SetActive(true);
                b.GetComponent<Transform>().GetChild(1).gameObject.SetActive(true);
                b.GetComponent<Transform>().GetChild(2).gameObject.SetActive(true);
                b.SetActive(true);
                this.gameObject.GetComponent<Test>().FrontPage();
            }
        else 
        {
            //m_InputField.DeactivateInputField();
            b.GetComponent<Image>().sprite = EmptySearch;
            b.GetComponent<Transform>().GetChild(0).gameObject.SetActive(false);
            b.GetComponent<Transform>().GetChild(1).gameObject.SetActive(false);
            b.GetComponent<Transform>().GetChild(2).gameObject.SetActive(false);
            b.SetActive(true);
            this.gameObject.GetComponent<Test>().FrontPage();
        }

        /*if(string.Equals(a.GetComponent<TMP_InputField>().text,"cmd",System.StringComparison.CurrentCultureIgnoreCase))
        {
            b.SetActive(true);
        } */
    }
}
