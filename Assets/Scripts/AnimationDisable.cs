using UnityEngine;

public class AnimationDisable : MonoBehaviour
{
    public GameObject a, b;
    private void DisableCanvas()
    {
        a.SetActive(false);
        b.SetActive(true);
    }
}