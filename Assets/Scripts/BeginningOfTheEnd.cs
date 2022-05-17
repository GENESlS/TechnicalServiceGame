using UnityEngine;

public class BeginningOfTheEnd : MonoBehaviour
{
    bool correct;
    public GameObject G1, G2, G3, G4, Red;

    int answer;

    GameObject x;
    AudioManager y;

    private void Start()
    {
        x = GameObject.Find("AudioManager");
        y = x.GetComponent<AudioManager>();
    }
    void OnDisable()
    {
        switch (answer) {
                case 1:
                    G1.SetActive(true);
                    break;
                case 2:
                    G2.SetActive(true);
                    break;
                case 3:
                    G3.SetActive(true);
                    break;
                case 4:
                    G4.SetActive(true);
                    break;
            }
        if (correct) 
        {
            y.Play("Success");
        } else {
           // Green.SetActive(true);
            Red.SetActive(true);
            y.Play("Fail");
        }
    }
    public void IsCorrectAnswer(bool correct)
    {
        this.correct = correct;
    }

    public void Answer(int answer)
    {
        this.answer = answer;
    }
}
