using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MiddleUnitTest
{

    [UnityTest]
    public IEnumerator CheckEulerAngles()
    {
        var go = new GameObject();

        MiddleScript middleScript = go.AddComponent<MiddleScript>();

        yield return null;
        var col = new GameObject().AddComponent<BoxCollider>();
        middleScript.OnTriggerEnter(col);
        Assert.True(Mathf.Approximately(col.transform.eulerAngles.x, 1));
        Assert.True(Mathf.Approximately(col.transform.eulerAngles.y, 1));
        Assert.True(Mathf.Approximately(col.transform.eulerAngles.z, 1));
    }

    [UnityTest]
    public IEnumerator CheckEulerAnglesWithTag()
    {
        var go = new GameObject();

        MiddleScript middleScript = go.AddComponent<MiddleScript>();

        yield return null;

        var col = new GameObject
        {
            tag = "Finish"
        }.AddComponent<BoxCollider>();

        middleScript.OnTriggerEnter(col);
        Assert.True(Mathf.Approximately(col.transform.eulerAngles.x, 0),$"X: {col.transform.eulerAngles.x}");
        Assert.True(Mathf.Approximately(col.transform.eulerAngles.y, 0),$"Y: {col.transform.eulerAngles.y}");
        Assert.True(Mathf.Approximately(col.transform.eulerAngles.z, 0),$"Z: {col.transform.eulerAngles.z}");
    }
}
