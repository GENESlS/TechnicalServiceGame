using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class MenuPlayerInfo : MonoBehaviour
{
    private string key;
    void Start()
    {
        if (PlayerPrefs.HasKey(key))
        {
            key = PlayerPrefs.GetString("name");
            this.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text += key;
            this.gameObject.GetComponent<Image>().enabled = true;
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(2).gameObject.SetActive(true);
        }
    }

    public void DeleteProfile()
    {
        PlayerPrefs.DeleteAll();
        this.gameObject.SetActive(false);
    }

    
}
