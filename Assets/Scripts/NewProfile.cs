using TMPro;
using UnityEngine;

public class NewProfile : MonoBehaviour
{
    public GameObject Name;
    public GameObject hobby;
    TMP_Text a;
    public void SaveProfile()
    {
        a.SetText("Seçin");
        if (Name.GetComponent<TMP_InputField>().text != "" 
        && hobby.GetComponent<TMP_Dropdown>().itemText != a)
        {
            PlayerPrefs.SetString("name", Name.GetComponent<TMP_InputField>().text);
            PlayerPrefs.SetString("hobby", hobby.GetComponent<TMP_Dropdown>().itemText.ToString());
            PlayerPrefs.Save();
        }
    }
}
