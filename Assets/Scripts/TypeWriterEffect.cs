using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    [HideInInspector]
    bool isDone = false;

    public bool IsDone { get => isDone; set => isDone = value; }

    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0,i);
            GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
        IsDone = true;
    }

    
}
