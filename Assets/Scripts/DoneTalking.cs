using UnityEngine;
using UnityEngine.UI;

public class DoneTalking : MonoBehaviour
{
    public GameObject SpeechText;

    private void Update()
    {
        if (SpeechText.GetComponent<TypeWriterEffect>().IsDone){
            this.gameObject.GetComponent<Image>().enabled = true;
            this.gameObject.GetComponent<Button>().enabled = true;
            this.gameObject.GetComponent<Animator>().enabled = true;
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.enabled = false;
        }
    }
}
