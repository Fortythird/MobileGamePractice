using UnityEngine;

public class CrashlyticsTester : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void ThrowException()
    {
        throw new System.Exception("You are idiot");
    }
}