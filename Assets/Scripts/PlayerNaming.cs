using TMPro;
using UnityEngine;

public class PlayerNaming : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.HasKey("name")) 
            this.GetComponent<TMP_Text>().text = PlayerPrefs.GetString("name") + " :";
    }

}
