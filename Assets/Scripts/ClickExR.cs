using UnityEngine.UI;
using UnityEngine;

public class ClickExR : MonoBehaviour
{
	public Button yourButton;
	public GameObject a, b;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		if (a.activeInHierarchy)
		{
			a.SetActive(false);
			b.SetActive(true);
		}
		else
		{
			a.SetActive(true);
			b.SetActive(false);
		}
	}
}
