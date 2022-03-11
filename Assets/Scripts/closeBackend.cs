using UnityEngine;

public class closeBackend : MonoBehaviour
{
    GameObject a, b;
    private void OnEnable()
    {
        try
        {
            a.SetActive(false);
            b.SetActive(false);
        }
        finally {}
    }
}
