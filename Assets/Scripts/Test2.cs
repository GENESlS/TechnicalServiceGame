using UnityEngine;

public class Test2 : MonoBehaviour
{
    public GameObject Star;
    Transform t;
    void Start()
    {
        t = Star.GetComponent<Transform>();
    }

    public void Frontier()
    {
        t.SetAsLastSibling();
    }
}
