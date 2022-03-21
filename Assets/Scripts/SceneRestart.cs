using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneRestart : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
