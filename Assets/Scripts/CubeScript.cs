using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float InitialPointX;
    public bool IsIncrementing;
    public bool FirstFrameHappened;
    public bool StartHappened;
    // Start is called before the first frame update
    public void Start()
    {
        StartHappened = true;
        InitialPointX = transform.position.x;
        IsIncrementing = true;
    }

    // Update is called once per frame
    public void Update()
    {
        FirstFrameHappened = true;
        IncrementX();
    }

    public void IncrementX()
    {
        FirstFrameHappened = true;
        transform.position += new Vector3(0.01f, 0, 0);

        if (transform.position.x >= 2)
        {
            transform.position = new Vector3(InitialPointX, 0, 0);
        }
    }
}
