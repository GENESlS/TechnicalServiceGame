using UnityEngine.UI;
using UnityEngine;

public class asd : MonoBehaviour
{
    private void OnDisable()
    {
        this.GetComponent<Image>().sprite = default;
    }
}
