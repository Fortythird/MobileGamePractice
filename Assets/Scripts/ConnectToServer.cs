using UnityEngine;
using Photon.Pun;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject disableOnLoadLobby;
    [SerializeField]
    private GameObject enableOnLoadLobby;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        disableOnLoadLobby.SetActive(false);
        enableOnLoadLobby.SetActive(true);
    }
}
