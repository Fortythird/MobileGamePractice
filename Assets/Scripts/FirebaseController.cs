using Firebase.Analytics;
using Firebase.Crashlytics;
using UnityEngine;

public class FirebaseController : MonoBehaviour
{
    void Start()
    {
        Firebase.FirebaseApp.LogLevel = Firebase.LogLevel.Debug;

        FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);

        Crashlytics.ReportUncaughtExceptionsAsFatal = true;
        Crashlytics.IsCrashlyticsCollectionEnabled = true;

        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                Firebase.FirebaseApp app = Firebase.FirebaseApp.DefaultInstance;

                Debug.Log("Firebase loaded");
                Debug.Log(Crashlytics.IsCrashlyticsCollectionEnabled);
                Debug.Log(Crashlytics.ReportUncaughtExceptionsAsFatal);

                FirebaseAnalytics.LogEvent(FirebaseAnalytics.EventAppOpen);
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));

                Debug.LogWarning("Failed loading Firebase");
            }
        });

        DontDestroyOnLoad(this);
    }
}
