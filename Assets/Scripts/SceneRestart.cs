using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneRestart : MonoBehaviour
{
    private int level;

    private void Start()
    {
        level = PlayerPrefs.GetInt("level", 1);
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextScene()
    {
        if (level != 5)
        {
            if (level < (SceneManager.GetActiveScene().buildIndex + 2) / 2 && PlayerPrefs.HasKey("name")) 
            {
                PlayerPrefs.SetInt("level", (SceneManager.GetActiveScene().buildIndex + 2) / 2);
                PlayerPrefs.Save();
            }
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BacktoMenu(bool levelComplete)
    {
        if (levelComplete) 
        {
            if (level < (SceneManager.GetActiveScene().buildIndex + 2) / 2 && PlayerPrefs.HasKey("name")) 
            {
                PlayerPrefs.SetInt("level", (SceneManager.GetActiveScene().buildIndex + 2) / 2);
                PlayerPrefs.Save();
            }
        }
        SceneManager.LoadScene("Menu");
    }
}
