using UnityEngine;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    float timeLeft = 2f;

    //[HideInInspector] public static float startTime;
    public GameObject a, b;
    private void OnEnable()
    {
        timeLeft = 2f;
    } 
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            this.gameObject.SetActive(false);
            a.SetActive(true);
            b.SetActive(true);
        } 
    }
}
