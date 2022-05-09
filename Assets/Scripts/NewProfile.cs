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
        && dropdown.options[dropdown.value].text != a)
        {
            PlayerPrefs.SetString("name", Name.GetComponent<TMP_InputField>().text);
            PlayerPrefs.SetString("hobby", dropdown.options[dropdown.value].text);
            PlayerPrefs.Save();
        }
    }
}
