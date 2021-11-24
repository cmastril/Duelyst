using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnGenerals : MonoBehaviour
{
    [SerializeField] private Board board;
    [SerializeField] private Deck deck;
    [SerializeField] private CardReferences cardReferences;

    public void SpawnGeneralProcedure()
    {
        if (PhotonNetwork.IsMasterClient == true)
        {
            int masterPosition = Random.Range(0, 2);

            PhotonView photonView = PhotonView.Get(this);
            photonView.RPC("TellClientsToSpawnTheirGenerals", RpcTarget.All, masterPosition);
        }
    }

    [PunRPC]
    public void TellClientsToSpawnTheirGenerals(int masterPosition)
    {
        int myGeneralID = deck.general.GetComponent<Card>().cardID;
        int myPosition = -5;

        if (PhotonNetwork.IsMasterClient == true)
        {
            myPosition = masterPosition;
        }
        else if (PhotonNetwork.IsMasterClient == false)
        {
            myPosition = (masterPosition + 1) % 2;
        }

        PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("SpawnMyGeneral", RpcTarget.All, myGeneralID, myPosition);
    }

    [PunRPC]
    public void SpawnMyGeneral(int curGeneralID, int position)
    {
        GameObject currentGeneral = cardReferences.idToCardObject(curGeneralID);

        if (position == 0)
        {
            Tile curTile = board.GetComponent<Board>().tiles2D[2, 0].GetComponent<Tile>();
            curTile.setCurrentCard(currentGeneral);
            curTile.displayCurrentCard();
        }
        else if (position == 1)
        {
            Tile curTile = board.GetComponent<Board>().tiles2D[2, 8].GetComponent<Tile>();
            curTile.setCurrentCard(currentGeneral);
            curTile.displayCurrentCard();
        }
    }
}
