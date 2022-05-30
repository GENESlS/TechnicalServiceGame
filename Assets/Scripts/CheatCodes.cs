using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheatCodes : MonoBehaviour
{
    public static bool NoTimer = false;
    public GameObject CheatCode, NoTimeButton;
    TMP_InputField tMP_InputField;

    public AudioManager a;

    private void Start()
    {
        tMP_InputField = CheatCode.GetComponent<TMP_InputField>();
    }
    public void Cheating()
    {
        switch (tMP_InputField.text)
        {
            case "259753":
                SceneManager.LoadScene("Episode 2");
                NoTimer = false;
                a.Play("Click");
                tMP_InputField.text = "";
                //Debug.Log(CodeText);
                break;
            case "359753":
                SceneManager.LoadScene("Episode 3");
                NoTimer = false;
                a.Play("Click");
                tMP_InputField.text = "";
                //Debug.Log(CodeText);
                break;
            case "459753":
                SceneManager.LoadScene("Episode 4");
                NoTimer = false;
                a.Play("Click");
                tMP_InputField.text = "";
                //Debug.Log(CodeText);
                break;
            case "559753":
                SceneManager.LoadScene("Episode 5");
                NoTimer = false;
                a.Play("Click");
                tMP_InputField.text = "";
                //Debug.Log(CodeText);
                break;
            case "KillTime":
                NoTimeButton.SetActive(true);
                a.Play("Click");
                tMP_InputField.text = "";
                //Debug.Log(CodeText);
                break;
        } 
       /* if (CodeText == "259753")
        {
            Debug.Log("aa");
            SceneManager.LoadScene("Episode 2");
        } else if (CodeText == "359753")
        {
            SceneManager.LoadScene("Episode 3");
        } else if (CodeText == "459753")
        {
            SceneManager.LoadScene("Episode 4");
        } else if (CodeText == "559753")
        {
            SceneManager.LoadScene("Episode 5");
        } else if (CodeText == "KillTime")
        {
            Debug.Log("aa");
            NoTimeButton.SetActive(true);
        } */
    }

    public void NoTimeIsOn()
    {
        if (NoTimeButton.GetComponent<Toggle>().isOn)
            NoTimer = true;
        else 
            NoTimer = false;
    }
}
