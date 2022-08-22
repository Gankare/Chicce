using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public InputField userNameInput;
    public GameObject loading;
    public GameObject input;
    public GameObject button;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void OnClickConnect()
    {
        if (userNameInput.text.Length >= 1)
        {
            PhotonNetwork.NickName = userNameInput.text;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            loading.SetActive(true);
            input.SetActive(false);
            button.SetActive(false);
            PhotonNetwork.ConnectUsingSettings();
        }
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(); 
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
    public void PlayWithFriends()
    {
        PhotonNetwork.LoadLevel("Rooms");
    }
}
