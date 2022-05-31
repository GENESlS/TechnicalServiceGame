using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Star;
    Transform t;
    void Start()
    {
        t = Star.GetComponent<Transform>();
    }

    public void FrontPage()
    {
        t.SetAsLastSibling();
    }

}
