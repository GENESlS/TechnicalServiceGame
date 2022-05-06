using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private int sceneInd;
    private int key;
    public GameObject Stage2, Stage3, Stage4, Stage5;

    private void Start()
    {
        key = PlayerPrefs.GetInt("level", 1);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void CheckLevel()
    {
        if (key != 1)
        {
            switch (key)
            {
                case 2:
                    Stage2.SetActive(true);
                    break;
                case 3:
                    Stage2.SetActive(true);
                    Stage3.SetActive(true);
                    break;
                case 4:
                    Stage2.SetActive(true);
                    Stage3.SetActive(true);
                    Stage4.SetActive(true);
                    break;
                case 5:
                    Stage2.SetActive(true);
                    Stage3.SetActive(true);
                    Stage4.SetActive(true);
                    Stage5.SetActive(true);
                    break;
            }
        }
    }

    public void Loader(int a)
    {
        switch (a) 
        {
            case 1:
                sceneInd = 1;
                break;
            case 2:
                sceneInd = 3;
                break;
            case 3:
                sceneInd = 5;
                break;
            case 4:
                sceneInd = 7;
                break;
            case 5:
                sceneInd = 9;
                break;
        }
    }

    public void Goo()
    {
        SceneManager.LoadScene(sceneInd);
    }
}
