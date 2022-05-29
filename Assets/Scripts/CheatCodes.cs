using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheatCodes : MonoBehaviour
{
    public static bool NoTimer = false;
    public GameObject CheatCode, NoTimeButton;
    private string CodeText;

    public void Cheating()
    {
        CodeText = CheatCode.GetComponent<TMP_Text>().text;
        CheatCode.GetComponent<TMP_Text>().text = "";

        if (CodeText == "259753")
        {
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
            NoTimeButton.SetActive(true);
        }
    }

    public void NoTimeIsOn()
    {
        if (NoTimeButton.GetComponent<Toggle>().isOn)
            NoTimer = true;
        else 
            NoTimer = false;
    }
}
