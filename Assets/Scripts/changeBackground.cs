using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class changeBackground : MonoBehaviour
{
    public GameObject a, d, e, cmdInput, SearchBox;
    public Sprite b, c;

    bool flag = false;
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
        if (Input.GetKeyDown(KeyCode.Return) && flag == false)
        {
            this.gameObject.GetComponent<Test2>().FrontPage();
            d.SetActive(true);
            cmdInput.GetComponent<TMP_InputField>().ActivateInputField();
            SearchBox.SetActive(false);
            e.SetActive(true);
            flag = true;
        }
    }
}
