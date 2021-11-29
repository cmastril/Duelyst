using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Turn : MonoBehaviour
{
    [SerializeField] public string player1Name;
    [SerializeField] public string player2Name;

    [SerializeField] public string currentPlayersTurn;
}
