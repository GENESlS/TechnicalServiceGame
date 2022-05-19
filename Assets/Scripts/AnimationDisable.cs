using UnityEngine;

public class AnimationDisable : MonoBehaviour
{
    public GameObject a, b;
    private bool choice = false;
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

    private void AnimEndChoice()
    {
        a.SetActive(true);
        b.SetActive(false);
        if (choice)
        {
            Manager.GetComponent<HonorPoint>().Decrease(-25);
        } else Manager.GetComponent<HonorPoint>().Decrease(25);
    }

    public void Answer(bool T)
    {
        choice = T;
    }
}
