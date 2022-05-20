using UnityEngine.UI;
using UnityEngine;

public class asd : MonoBehaviour
{
    private bool minimize = false;
    private void OnDisable()
    {
        if (!minimize)
            this.GetComponent<Image>().sprite = default;
    }

    public void IsMinimized(bool choice)
    {
        minimize = choice;
    }
}
