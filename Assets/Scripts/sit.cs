using System.Collections;
using UnityEngine;

public class sit : MonoBehaviour
{
    public GameObject c, e;
    Vector3 temp;
    void Start()
    {
        temp = new Vector3(c.transform.localPosition.x, c.transform.localPosition.y, c.transform.localPosition.z);
        StartCoroutine(Startup());
        this.enabled = false;
    }
    
    IEnumerator Startup()
    {
        c.transform.localPosition = new Vector3((float)-0.0350000001,(float)1.34800005, (float)0.690999985);
        c.transform.Rotate(0, 180, 0);
        yield return new WaitForSeconds(4);
        c.transform.localPosition = temp;
        c.transform.Rotate(0, -180, 0);
        c.SetActive(false);
        e.SetActive(true);
    }
}
