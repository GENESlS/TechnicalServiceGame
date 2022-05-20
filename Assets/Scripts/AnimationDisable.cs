using UnityEngine;

public class AnimationDisable : MonoBehaviour
{
    public GameObject a, b;
    GameObject Manager;

    private void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");
    }
    private void DisableCanvas()
    {
        a.SetActive(false);
        b.SetActive(true);
    }

    private void ReverseScript()
    {
        a.SetActive(true);
        b.SetActive(false);
    }

}
