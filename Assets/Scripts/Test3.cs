using UnityEngine;

public class Test3 : MonoBehaviour
{
    public GameObject Star;
    Transform t;
    void Start()
    {
        t = Star.GetComponent<Transform>();
    }

    public void FrontLine()
    {
        t.SetAsLastSibling();
    }
}
