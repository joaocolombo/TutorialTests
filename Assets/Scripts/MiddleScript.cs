using System;
using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by " + other.transform.name);

        if (other.tag.Equals("Finish"))
            return;
        var quaternion = other.transform.eulerAngles;
        var newQuaternion = new Vector3(quaternion.x+1, quaternion.y + 1, quaternion.z+1);
        other.transform.eulerAngles = newQuaternion;
    }
}
