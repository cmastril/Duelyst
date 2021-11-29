using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class InitializeTurnCounter : MonoBehaviour
{
    [SerializeField] private Turn turn;

    public void StartTurnCounterProcedure()
    {
        if (PhotonNetwork.IsMasterClient == true)
        {
            string myNickname = PhotonNetwork.LocalPlayer.NickName;
            int randInt = Random.Range(0,2);

            PhotonView thisPhotonView = this.GetComponent<PhotonView>();
            thisPhotonView.RPC("TurnCounterProcedure2", RpcTarget.All, randInt, myNickname);
        }
    }

    [PunRPC]
    public void TurnCounterProcedure2(int masterPlayerPosition, string masterPlayerName)
    {
        if (masterPlayerPosition == 0)
        {
            turn.player1Name = masterPlayerName;
        }
        else if (masterPlayerPosition == 1)
        {
            turn.player2Name = masterPlayerName;
        }

        if (PhotonNetwork.IsMasterClient == false)
        {
            string myNickname = PhotonNetwork.LocalPlayer.NickName;
            PhotonView thisPhotonView = this.GetComponent<PhotonView>();

            thisPhotonView.RPC("TurnCounterProcedure3", RpcTarget.All, myNickname);
        }
    }

    [PunRPC]
    public void TurnCounterProcedure3(string secondPlayerName)
    {
        if (string.IsNullOrEmpty(turn.player1Name) == true)
        {
            turn.player1Name = secondPlayerName;
        }
        else if (string.IsNullOrEmpty(turn.player2Name) == true)
        {
            turn.player2Name = secondPlayerName;
        }

        PhotonView thisPhotonView = this.GetComponent<PhotonView>();
        thisPhotonView.RPC("InitializeCurrentPlayerVariable", RpcTarget.All);
    }

    [PunRPC]
    public void InitializeCurrentPlayerVariable()
    {
        turn.currentPlayersTurn = turn.player1Name;
    }
}
