using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void InitiateWithoutStartFirstFrame()
    {
        var go = new GameObject();

        CubeScript cubeScript = go.AddComponent<CubeScript>();

        Assert.IsFalse(cubeScript.FirstFrameHappened);
        Assert.IsFalse(cubeScript.StartHappened);
    }

    [UnityTest]
    public IEnumerator InitiateWithStartFirstFrame()
    {
        var go = new GameObject();

        CubeScript cubeScript = go.AddComponent<CubeScript>();

        cubeScript.Start();

        yield return null;// one frame
        cubeScript.Update();

        yield return null;// two frame
        cubeScript.Update();

        Assert.True(cubeScript.FirstFrameHappened);
        Assert.True(cubeScript.StartHappened);
        Assert.AreEqual(0.02f,cubeScript.transform.position.x);

    }



    [UnityTest]
    public IEnumerator Initiate12Times()
    {
        var go = new GameObject();

        CubeScript cubeScript = go.AddComponent<CubeScript>();

        cubeScript.Start();

        foreach (var index in Enumerable.Range(0,201))
        {
            yield return null;// one frame
            cubeScript.Update();
        }
        
        Assert.True(cubeScript.FirstFrameHappened);
        Assert.True(cubeScript.StartHappened);
        Assert.AreEqual(0f, cubeScript.transform.position.x);
    }
}
