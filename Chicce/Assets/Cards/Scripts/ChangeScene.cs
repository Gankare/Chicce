using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Start()
    {
        
    }

    public void PlayWithFriends()
    {
        PhotonNetwork.LoadLevel("Rooms");
    }

}
