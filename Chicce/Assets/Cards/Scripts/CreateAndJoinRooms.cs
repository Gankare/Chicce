using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField]
    public Text inputText;

    
    public void CreateOrJoinRoom()
    {
        if (!PhotonNetwork.IsConnected)
            return;
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 4;
        options.PlayerTtl = 60000;
        options.EmptyRoomTtl = 10;
        PhotonNetwork.JoinOrCreateRoom(inputText.text, options, TypedLobby.Default); //Works, no idea why its red
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Created room successfully", this);
        PhotonNetwork.LoadLevel("Game");
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room successfully", this);
        PhotonNetwork.LoadLevel("Game");
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to Create room" + message, this);
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to join room" + message, this);
    }
}
