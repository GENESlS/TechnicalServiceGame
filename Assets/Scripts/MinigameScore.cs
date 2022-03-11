using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class MinigameScore : MonoBehaviour
{
    public GameObject textBox, a, b, c, d, g, x, y, z;
    GameObject h;
    //GameObject[] inputs;
    public AudioManager q;
    Sprite s, t, u, v;
    public int flag = 0;
    void Start()
    {
        h = GameObject.Find("AudioManager");
        q = h.GetComponent<AudioManager>();
        //x = GameObject.Find("comps");
        //y = GameObject.Find("comps 1");
        //z = GameObject.Find("comps 2");
        s = a.GetComponent<Image>().sprite;
        t = x.GetComponent<Image>().sprite;
        u = y.GetComponent<Image>().sprite;
        v = z.GetComponent<Image>().sprite;
        //inputs = GameObject.FindGameObjectsWithTag("gInputs");
    }

    // Update is called once per frame
    void Update()
    {
        if (a.GetComponent<Image>().sprite != s &&
            b.GetComponent<Image>().sprite != s &&
            c.GetComponent<Image>().sprite != s)
        {
            if (a.GetComponent<Image>().sprite == u &&
                b.GetComponent<Image>().sprite == t &&
                c.GetComponent<Image>().sprite == v )
            {
                if (flag == 0)
                {
                    d.SetActive(true);
                    g.SetActive(false);
                    q.Play("Success");
                    flag = 1;
                }
            } else
            {
                q.Play("Fail");
                a.GetComponent<Image>().sprite = s;
                b.GetComponent<Image>().sprite = s;
                c.GetComponent<Image>().sprite = s;
            }
        }
    }

    /*
    public void tc1()
    {
        textBox.GetComponent<TMP_Text>().text = "Sorun devam ediyor, " +
                                                "sorun gidericiyi dene.";
    } */
}
