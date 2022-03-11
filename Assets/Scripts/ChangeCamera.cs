using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject x, z;
    
    public void Change()
    {
        this.gameObject.SetActive(false);
        z.SetActive(true);
        x.SetActive(true);
    }
}
