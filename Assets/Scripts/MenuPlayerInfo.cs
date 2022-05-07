using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class MenuPlayerInfo : MonoBehaviour
{
    private string key = "name";
    public GameObject a;
    void Start()
    {
        if (PlayerPrefs.HasKey(key))
        {
            key = " " + PlayerPrefs.GetString(key, "Player");
            //Debug.Log(key);
            this.gameObject.GetComponent<Image>().enabled = true;
            this.transform.GetChild(0).gameObject.SetActive(true);
            //Debug.Log(a.GetComponent<TextMeshPro>().text);
            this.transform.GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(2).gameObject.SetActive(true);
            this.transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text += key;
        }
    }

    public void DeleteProfile()
    {
        PlayerPrefs.DeleteAll();
        this.gameObject.SetActive(false);
    }

    
}
