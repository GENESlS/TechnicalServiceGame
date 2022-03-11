using TMPro;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public GameObject a, b, c;
    float timeLeft = 1f;
    public TMP_Text m_TextComponent;
    Vector3 localPos;
    private void Awake()
    {
        localPos = gameObject.transform.localPosition;
    }
    private void OnEnable()
    {
        a.GetComponent<TextMeshProUGUI>().enabled = false;
        timeLeft = 1f;
    }

    private void OnDisable()
    {
        a.GetComponent<TextMeshProUGUI>().enabled = true;
        transform.localPosition = localPos;
    }
    public void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            a.GetComponent<TextMeshProUGUI>().enabled = true;
        }

        for (int i = 0; i < b.transform.childCount; ++i)
        {
            GameObject abc = b.transform.GetChild(i).gameObject;
            if (abc.activeSelf)
                {
                    if (abc.GetComponent<RectTransform>().sizeDelta.y < 100)
                    {
                        transform.localPosition = abc.transform.localPosition + new Vector3(-88, -50, 0);
                    }
                    else
                    {
                        transform.localPosition = abc.transform.localPosition + new Vector3(-88, -150, 0);
                    }
                }
        }
    
        

        if (Input.GetKeyDown(KeyCode.Return))
        {
            c.SetActive(true);
            GameObject.Find("remText").SetActive(false);
            for (int i = 0; i < b.transform.childCount; ++i)
            {
                GameObject abc = b.transform.GetChild(i).gameObject;
                if (abc.activeInHierarchy)
                {
                    abc.SetActive(false);
                }
            }
            a.SetActive(false);
            c.GetComponent<TMP_InputField>().ActivateInputField();
        }
    }

    public void Replace()
    {
        m_TextComponent.text = c.GetComponent<TMP_InputField>().text;
    }
}
