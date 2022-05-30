using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class changeBackground : MonoBehaviour
{
    public GameObject a, d, e;
    public Sprite b, c;
    public void Change()
    {
        //c = a.GetComponent<Image>().sprite;
        a.GetComponent<Image>().sprite = b;
    }
    public void Rechange()
    {
        a.GetComponent<Image>().sprite = c;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.gameObject.GetComponent<Test2>().FrontPage();
            d.SetActive(true);
            GameObject.Find("cmdInput").GetComponent<TMP_InputField>().ActivateInputField();
            GameObject.Find("SearchBox").SetActive(false);
            e.SetActive(true);
        }
    }
}
