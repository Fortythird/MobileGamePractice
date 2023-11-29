using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] Text coinsText;

    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Carrots: " + coins;
            collectionSound.Play();
            Firebase.Analytics.FirebaseAnalytics.LogEvent("Carrot has been picked up");
        }
    }

    public int GetCoins()
    {
        return coins;
    }

    public void SetCoins(int value)
    {
        coins = value;
        coinsText.text = "Carrots: " + coins;
    }
}