using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Connect : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom();
        }

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene(1);
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Photon.Realtime.RoomOptions roomOptions = new Photon.Realtime.RoomOptions();
        roomOptions.MaxPlayers = 2;

        PhotonNetwork.CreateRoom("", roomOptions, Photon.Realtime.TypedLobby.Default);
    }
}
