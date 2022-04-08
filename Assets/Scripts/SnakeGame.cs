using System.Collections;
using UnityEngine;

public class SnakeGame : MonoBehaviour
{
    public GameObject x;
    string pivot;
    public float speed = 2;
    Vector3 movement;

    private void Start()
    {
        pivot = "n";
    }

    private void OnEnable()
    {
        x.transform.localPosition = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("up"))
        {
            pivot = "n";
        } else if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            pivot = "a";
        } else if (Input.GetKeyDown("s") || Input.GetKeyDown("down"))
        {
            pivot = "s";
        } else if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            pivot = "d";
        }

            switch (pivot)
        {
            case "n":
                movement = new Vector3(0, 5, 0);
                x.transform.Translate(movement * speed * 10 * Time.deltaTime);
                break;
            case "a":
                movement = new Vector3(-5, 0, 0);
                x.transform.Translate(movement * speed * 10 * Time.deltaTime);
                break;
            case "s":
                movement = new Vector3(0, -5, 0);
                x.transform.Translate(movement * speed * 10 * Time.deltaTime);
                break;
            case "d":
                movement = new Vector3(5, 0, 0);
                x.transform.Translate(movement * speed * 10 * Time.deltaTime);
                break;
        }


    }
}
