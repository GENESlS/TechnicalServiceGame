using System.Collections;
using UnityEngine;

public class SnakeGame : MonoBehaviour
{
    public GameObject x;
    string pivot, keyPress;
    public float speed = 2;
    Vector3 movement;

    private void Start()
    {
        pivot = "n";
    }


    void FixedUpdate()
    {
        switch (keyPress)
        {
            case string key when key.Equals("w",System.StringComparison.CurrentCultureIgnoreCase) :
                pivot = "n";
                break;
            case string key when key.Equals("a", System.StringComparison.CurrentCultureIgnoreCase):
                pivot = "a";
                break;
            case string key when key.Equals("s", System.StringComparison.CurrentCultureIgnoreCase):
                pivot = "s";
                break;
            case string key when key.Equals("d", System.StringComparison.CurrentCultureIgnoreCase):
                pivot = "d";
                break;
            case "up":
                pivot = "n";
                break;
            case "left":
                pivot = "a";
                break;
            case "down":
                pivot = "s";
                break;
            case "right":
                pivot = "d";
                break;
        }

        switch (pivot)
        {
            case "n":
                movement = new Vector3(0, 5, 0);
                x.transform.Translate(movement * speed * Time.deltaTime);
                break;
            case "a":
                movement = new Vector3(-5, 0, 0);
                x.transform.Translate(movement * speed * Time.deltaTime);
                break;
            case "s":
                movement = new Vector3(0, -5, 0);
                x.transform.Translate(movement * speed * Time.deltaTime);
                break;
            case "d":
                movement = new Vector3(5, 0, 0);
                x.transform.Translate(movement * speed * Time.deltaTime);
                break;
        }


    }
}
