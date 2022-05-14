using UnityEngine;

public class AppearGeneric : MonoBehaviour
{
    private static float t;
    public float timeLeft = 10;
    public GameObject a, b;
    private void OnDisable()
    {
        t = timeLeft;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Fonc();
            this.gameObject.SetActive(false);
        }
    }

    void Fonc()
    {
        a.GetComponent<Dialog>().Talk(false);
        return;
    }
}
