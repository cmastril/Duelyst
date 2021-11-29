using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class EndTurnButton : MonoBehaviour
{
    [SerializeField] private Turn turn;

    public void OnEndTurnButtonPress()
    {
        string myName = PhotonNetwork.LocalPlayer.NickName;

        if (turn.currentPlayersTurn == myName)
        {
            PhotonView thisPhotonView = this.GetComponent<PhotonView>();
            thisPhotonView.RPC("ChangePlayerTurn", RpcTarget.All);
        }
    }

    [PunRPC]
    public void ChangePlayerTurn()
    {
        if (turn.currentPlayersTurn == turn.player1Name)
        {
            turn.currentPlayersTurn = turn.player2Name;
        }
        else if (turn.currentPlayersTurn == turn.player2Name)
        {
            turn.currentPlayersTurn = turn.player1Name;
        }
    }
}
