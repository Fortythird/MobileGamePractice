using System;
using UnityEngine;

public class ExceptionByTime : MonoBehaviour
{

    int updatesBeforeException;

    // Use this for initialization
    void Start()
    {
        updatesBeforeException = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Call the exception-throwing method here so that it's run
        // every frame update
        throwExceptionEvery60Updates();
    }

    // A method that tests your Crashlytics implementation by throwing an
    // exception every 60 frame updates. You should see reports in the
    // Firebase console a few minutes after running your app with this method.
    void throwExceptionEvery60Updates()
    {
        if (updatesBeforeException > 0)
        {
            updatesBeforeException--;
        }
        else
        {
            // Set the counter to 10 updates
            updatesBeforeException = 10;

            // Throw an exception to test your Crashlytics implementation
            throw new System.Exception("test exception please ignore");
        }
    }
}