using UnityEngine;

public class BeginningOfTheEnd : MonoBehaviour
{
    bool correct;
    public GameObject G1, G2, G3, G4, Red, E1, E2, E3, E4, E5, E6, E7, E8, E9, E10, E11, E12;

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
        
        E1.SetActive(true); E2.SetActive(true); E3.SetActive(true); E4.SetActive(true); E5.SetActive(true);
        E6.SetActive(true); E7.SetActive(true); E8.SetActive(true); E9.SetActive(true); E10.SetActive(true);
        E11.SetActive(true); E12.SetActive(true);

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
