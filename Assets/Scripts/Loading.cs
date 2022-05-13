using UnityEngine;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeLeft = 2f;

    //private float saveTime;
    public GameObject a, b;

    /* private void OnEnable()
    {
        StartCoroutine("Update");
    } */
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            StopAllCoroutines();
            this.gameObject.SetActive(false);
            a.SetActive(true);
            b.SetActive(true);
        } 
    }
}
