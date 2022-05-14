using UnityEngine;

public class HobbySet : MonoBehaviour
{
    public GameObject gameDialog, bookDialog, sportDialog, defaultDialog;
    void Start()
    {
        if (PlayerPrefs.HasKey("hobby")){
            string a = PlayerPrefs.GetString("hobby");
            switch (a)
                {
                    case "Oyun":
                        gameDialog.SetActive(true);
                        break;
                    case "Kitap":
                        bookDialog.SetActive(true);
                        break;
                    case "Spor":
                        sportDialog.SetActive(true);
                        break;
                }
                defaultDialog.SetActive(false);
        }
    }

}
