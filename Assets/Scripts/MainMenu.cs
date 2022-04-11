using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private int sceneInd;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
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
