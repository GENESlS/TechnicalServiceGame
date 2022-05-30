using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class changeBackground : MonoBehaviour
{
    public GameObject a, d, e, cmdInput;
    public Sprite b, c;

    //bool flag = false;
    public void Change()
    {
        //c = a.GetComponent<Image>().sprite;
        a.GetComponent<Image>().sprite = b;
    }
    public void Rechange()
    {
        a.GetComponent<Image>().sprite = c;
    }

    /*
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) /*&& flag == false)
        {
            Debug.Log("aa");
            OpenKeyPress();
            //gameObject.SetActive(false);
            //flag = true;
        }
    }

    void OpenKeyPress()
    {
        this.gameObject.GetComponent<Test>().FrontPage();
        d.SetActive(true);
        cmdInput.GetComponent<TMP_InputField>().ActivateInputField();
        //SearchBox.SetActive(false);
        e.SetActive(true);
        gameObject.SetActive(false);
    } */
}
