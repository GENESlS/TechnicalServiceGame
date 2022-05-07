using TMPro;
using UnityEngine;

public class NewProfile : MonoBehaviour
{
    public GameObject Name;
    public GameObject hobby;
    string a = "Seçin";
    TMP_Dropdown dropdown;
    void Start()
    {
        dropdown = hobby.GetComponent<TMP_Dropdown>();
    }
    public void SaveProfile()
    {
        if (Name.GetComponent<TMP_InputField>().text != "" 
        && hobby.GetComponent<TMP_Dropdown>().itemText.ToString() != a)
        {
            PlayerPrefs.SetString("name", Name.GetComponent<TMP_InputField>().text);
            PlayerPrefs.SetString("hobby", dropdown.options[dropdown.value].text);
            PlayerPrefs.Save();
        }
    }
}
