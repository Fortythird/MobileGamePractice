using System.Collections;
using System.Collections.Generic;
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