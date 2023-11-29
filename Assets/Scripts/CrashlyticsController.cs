using Firebase.Crashlytics;
using UnityEngine;

public class CrashlyticsController : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(this);

        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                Firebase.FirebaseApp app = Firebase.FirebaseApp.DefaultInstance;

                Debug.Log("Crashlytics loaded");
                Crashlytics.ReportUncaughtExceptionsAsFatal = true;
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));

                Debug.LogWarning("Failed loading Firebase");
            }
        }
        );
    }
}
