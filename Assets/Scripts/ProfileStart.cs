
using UnityEngine;

public class ProfileStart : MonoBehaviour
{
    public GameObject ProfileStartup;
    void Start()
    {
        if (PlayerPrefs.HasKey("name")) {
            this.gameObject.SetActive(false);
            ProfileStartup.SetActive(true);
        }
    }
}
