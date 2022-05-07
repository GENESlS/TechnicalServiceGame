using UnityEngine;

public class HobbySet : MonoBehaviour
{
    public GameObject gameDialog, bookDialog, sportDialog;
    void Start()
    {
        if (PlayerPrefs.HasKey("hobby")){
            string a = PlayerPrefs.GetString("hobby");
            //Debug.Log(a);
            if (a != "Spor")
            {
                switch (a)
                {
                    case "Oyun":
                        gameDialog.SetActive(true);
                        break;
                    case "Kitap":
                        bookDialog.SetActive(true);
                        break;
                }
                sportDialog.SetActive(false);
            }
        }
    }

}
