using TMPro;
using UnityEngine;

public class ClipboardEx : MonoBehaviour
{
    public GameObject clipboardText;

    public void CopyCode()
    {
        ClipboardExtension.CopyToClipboard(clipboardText.GetComponent<TMP_Text>().text);
    }
}
