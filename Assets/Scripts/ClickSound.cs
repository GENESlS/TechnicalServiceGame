using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioManager a;
    public void Click()
    {
        a.Play("Click");
    }
}
