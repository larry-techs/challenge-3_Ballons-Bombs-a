using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        startPosition = transform.position;
        Debug.Log(startPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPosition.x -repeatWidth)
        {
            transform.position = startPosition;
        }
       
        
    }
}