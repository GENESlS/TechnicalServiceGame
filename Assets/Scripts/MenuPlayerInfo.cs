using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class MenuPlayerInfo : MonoBehaviour
{
    public GameObject a;
    void Start()
    {
        if (PlayerPrefs.HasKey("name"))
        {
            string key = " " + PlayerPrefs.GetString("name", "Player");
            int level = PlayerPrefs.GetInt("level", 1);
            //Debug.Log(key);
            this.gameObject.GetComponent<Image>().enabled = true;
            this.transform.GetChild(0).gameObject.SetActive(true);
            //Debug.Log(a.GetComponent<TextMeshPro>().text);
            this.transform.GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(2).gameObject.SetActive(true);
            this.transform.GetChild(3).gameObject.SetActive(true);
            this.transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text += key;
            this.transform.GetChild(3).gameObject.GetComponent<TMP_Text>().text += " " + level;
        }
    }

    public void DeleteProfile()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        this.gameObject.SetActive(false);
    }

    
}
