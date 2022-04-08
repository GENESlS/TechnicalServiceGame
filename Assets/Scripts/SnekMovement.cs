using System.Collections.Generic;
using UnityEngine;

public class SnekMovement : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;
    private List<Transform> _segments= new List<Transform>();
    public Transform segmentPrefab;

    private float time = 1;
    public GameObject a;

    //public int initialSize = 4;
    private void OnEnable()
    {
        ResetState();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            _direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.S)) {
            _direction = Vector2.down;
        } else if (Input.GetKeyDown(KeyCode.A)) {
            _direction = Vector2.left;
        } else if (Input.GetKeyDown(KeyCode.D)) {
            _direction = Vector2.right; 
        }

        time += Time.deltaTime;
        if ((int)time %5 == 0) { a.GetComponent<NonStopTimer>().SettimeLeft(a.GetComponent<NonStopTimer>().GettimeLeft() - 4); time++; } 

    
    }

    private void FixedUpdate(){

        for (int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].position = _segments [i - 1].position;
        }

        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );
    }


    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.transform.SetParent(this.transform.parent,false);
        segment.position = _segments[_segments.Count - 1].position;
        //segment.localPosition = _segments[_segments.Count - 1].localPosition;
        _segments.Add(segment);
    }

    private void ResetState()
    {
        for (int i = 1; i < _segments.Count; i++) {
            Destroy(_segments[i].gameObject);
        }

        _segments.Clear();
        _segments.Add(this.transform);

      /*  for (int i = 1; i < this.initialSize; i++) {
            _segments.Add(Instantiate(this.segmentPrefab));
        } */

        this.transform.localPosition = Vector3.zero;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Food") {
            Grow(); Grow(); Grow(); Grow(); Grow();
        } else if (other.tag == "Obstacle") {
            ResetState(); //Debug.Log("aa");
        }
    }
}

