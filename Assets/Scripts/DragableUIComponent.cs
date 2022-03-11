using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragableUIComponent : EventTrigger
{
    public bool startDragging;
    GameObject a, b, c;
    RectTransform rectTransform, rectTransform1, rectTransform2;
    Sprite s;
    Vector2 v;
    Vector3 x;
    void Start()
    {
        x = transform.position;
        a = GameObject.Find("slot 1");
        b = GameObject.Find("slot 2");
        c = GameObject.Find("slot 3");
        rectTransform = a.GetComponent<RectTransform>();
        rectTransform1 = b.GetComponent<RectTransform>();
        rectTransform2 = c.GetComponent<RectTransform>();
        s = a.GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (startDragging)
        {
            v = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.position = v;
            Vector2 point = v - new Vector2(Screen.width / 2, Screen.height / 2);
            /*if (IsPointInRT(point, rectTransform) && a.GetComponent<Image>().sprite.name == "Background")
            {
                a.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                this.gameObject.SetActive(false);
            } else if (IsPointInRT(point, rectTransform1) && b.GetComponent<Image>().sprite.name == "Background")
            {
                b.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                this.gameObject.SetActive(false);
            }
            else if (IsPointInRT(point, rectTransform2) && c.GetComponent<Image>().sprite.name == "Background")
            {
                c.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                this.gameObject.SetActive(false);
            }*/
            
            if (IsPointInRT(point, rectTransform))
            {
               if (a.GetComponent<Image>().sprite == s)
                  {
                    a.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                    transform.position = x;
                    startDragging = false;
                    //this.enabled = false;
                  }
            } 
            else if (IsPointInRT(point, rectTransform1))                       
            {
               if (b.GetComponent<Image>().sprite == s)
                  {
                    b.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                    transform.position = x;
                    startDragging = false;
                    //this.enabled = false;
                }
            }
            else if (IsPointInRT(point, rectTransform2))
            {
               if (c.GetComponent<Image>().sprite == s)
                  {
                    c.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                    transform.position = x;
                    startDragging = false;
                    //this.enabled = false;
                }
            } 
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        startDragging = true;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        startDragging = false;
    }

    bool IsPointInRT(Vector2 point, RectTransform rt)
    {
        // Get the rectangular bounding box of your UI element
        Rect rect = rt.rect;

        // Get the left, right, top, and bottom boundaries of the rect
        float leftSide = rt.anchoredPosition.x - rect.width / 2;
        float rightSide = rt.anchoredPosition.x + rect.width / 2;
        float topSide = rt.anchoredPosition.y + rect.height / 2;
        float bottomSide = rt.anchoredPosition.y - rect.height / 2;

        //Debug.Log(leftSide + ", " + rightSide + ", " + topSide + ", " + bottomSide);

        // Check to see if the point is in the calculated bounds
        if (point.x >= leftSide &&
            point.x <= rightSide &&
            point.y >= bottomSide &&
            point.y <= topSide)
        {
            return true;
        }
        return false;
    }
}
