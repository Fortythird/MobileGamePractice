using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TMP_InputField createLobby;
    [SerializeField]
    private TMP_InputField joinLobby;


    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;

        PhotonNetwork.CreateRoom(createLobby.text, roomOptions);
    }

    public void JoinRoom() 
    {
        PhotonNetwork.JoinRoom(joinLobby.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Level");
    }
}
