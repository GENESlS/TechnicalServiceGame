using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneRestart : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
