using System.Collections;
using UnityEngine;

public class sit : MonoBehaviour
{
    public GameObject c, e;
    Vector3 temp;
    void Start()
    {
        temp = new Vector3(c.transform.localPosition.x, c.transform.localPosition.y, c.transform.localPosition.z);
        c.transform.localPosition = new Vector3(0, 2, 2);
        c.transform.Rotate(0, 171, 0);
        StartCoroutine(Startup());
        this.enabled = false;
    }

    IEnumerator Startup()
    {
        int z = 1;
        yield return new WaitForSecondsRealtime(2);
        c.transform.localPosition = temp;
        c.transform.Rotate(0, -171, 0);
        c.SetActive(false);
        e.SetActive(true);
    }
}
