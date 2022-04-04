using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;
    RectTransform a, b;

    private void Start()
    {
        a = GameObject.Find("Food").GetComponent<RectTransform>();
        b = GameObject.Find("GridArea").GetComponent<RectTransform>();
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        /*
        Bounds bounds = this.gridArea.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y); */
        Rect rect = b.rect;

        float leftSide = b.anchoredPosition.x - rect.width / 2;
        float rightSide = b.anchoredPosition.x + rect.width / 2;
        float topSide = b.anchoredPosition.y + rect.height / 2;
        float bottomSide = b.anchoredPosition.y - rect.height / 2;

        float x = Random.Range(leftSide, rightSide);
        float y = Random.Range(bottomSide, topSide);
        a.anchoredPosition = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Snek") {
            RandomizePosition();
        }
    }

}
