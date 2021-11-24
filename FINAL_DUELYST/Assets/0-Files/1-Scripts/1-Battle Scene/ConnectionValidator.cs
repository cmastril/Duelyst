using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ConnectionValidator : MonoBehaviour
{
    [SerializeField] private LogicManager gameLogic;

    void Update()
    {
        if (PhotonNetwork.PlayerList.Length == 2)
        {
            gameLogic.StartGameLogicProcedure();
            this.gameObject.SetActive(false);
        }
    }
}
