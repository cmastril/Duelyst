using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnGenerals : MonoBehaviour
{
    [SerializeField] private Board board;
    [SerializeField] private Deck deck;
    [SerializeField] private Turn turn;

    [SerializeField] private CardReferences cardReferences;
    

    public void SpawnGeneralProcedure()
    {
        if (PhotonNetwork.IsMasterClient == true)
        {
            PhotonView photonView = PhotonView.Get(this);
            photonView.RPC("TellPlayersToSpawnGenerals", RpcTarget.All);
        }
    }

    [PunRPC]
    public void TellPlayersToSpawnGenerals()
    {
        int position = -5;
        string myName = PhotonNetwork.LocalPlayer.NickName;
        Debug.Log(myName);

        if (turn.player1Name == myName)
        {
            position = 0;
        }
        else if (turn.player2Name == myName)
        {
            position = 1;
        }

        int curGeneralID = deck.general.GetComponent<Card>().cardID;

        PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("SpawnMyGeneral", RpcTarget.All, position, curGeneralID, myName);
    }

    [PunRPC]
    public void SpawnMyGeneral(int position, int currentGeneralID, string ownerPlayerName)
    {
        GameObject currentGeneralPrefab = cardReferences.idToCardObject(currentGeneralID);
        GameObject currentGeneral = Instantiate(currentGeneralPrefab, new Vector3(100,0,0), Quaternion.identity);

        Tile curTile = null;

        if (position == 0)
        {
            curTile = board.GetComponent<Board>().tiles2D[2, 0].GetComponent<Tile>();
        }
        else if (position == 1)
        {
            curTile = board.GetComponent<Board>().tiles2D[2, 8].GetComponent<Tile>();
        }

        curTile.setCurrentCard(currentGeneral);
        curTile.displayCurrentCard();
        curTile.currentCard.GetComponent<Card>().SetCardOwner(ownerPlayerName);
    }
}
