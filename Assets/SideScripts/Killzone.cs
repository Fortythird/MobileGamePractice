using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{
    [SerializeField]
    private bool isFinish = false;

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (!isFinish) coll.GetComponent<FirstPersonController>().Death();
            else coll.GetComponent<FirstPersonController>().Finish();
        }
    }
}
