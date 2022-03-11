using UnityEngine;
using UnityEngine.UI;

public class ClickExample : MonoBehaviour
{
	public Button yourButton;
	public GameObject a;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		if(a.activeInHierarchy)
        {
			a.SetActive(false);
			//b.SetActive(true);
		}
		else
        {
			a.SetActive(true);
			//b.SetActive(false);
        }
		//b.SetActive(false);
	}
}
