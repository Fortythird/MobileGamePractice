using Cinemachine;
using Photon.Pun;
using StarterAssets;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;

    void Start()
    {
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, transform.GetChild(0).position, Quaternion.identity);
        if (player.GetComponent<PhotonView>().ViewID == 2)
        {
            player.transform.position = transform.GetChild(1).transform.position;
            player.transform.rotation = transform.GetChild(1).transform.rotation;
        }
        player.GetComponent<FirstPersonController>().SetSpawn();
    }
}
