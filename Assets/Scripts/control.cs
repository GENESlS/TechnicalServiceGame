using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    [System.Obsolete]
    private void OnEnable()
    {
        if(GameObject.Find("Security_Pop-Up").active)
        {
            GameObject.Find("Security_Pop-Up").SetActive(false);
        }
    }
}
