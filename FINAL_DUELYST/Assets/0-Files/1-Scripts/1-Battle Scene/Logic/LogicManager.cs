using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    [SerializeField] private StartChecker startChecker;

    [SerializeField] private FillDeck fillDeck;

    [SerializeField] private FillReplaceSlots fillReplaceSlots;
    [SerializeField] private DisplayReplaceSlots displayReplaceSlots;

    [SerializeField] private FillHand fillHand;

    [SerializeField] private InitializeBoardTiles initializeBoardTiles;
    [SerializeField] private SpawnGenerals spawnGenerals;

    public void StartGameLogicProcedure()
    {
        startChecker.StartCheckerProcedure();

        fillDeck.FillDeckWithTestUnits();

        fillReplaceSlots.FillReplaceSlotsFromDeck();
        displayReplaceSlots.DisplayReplaceSlotCards();

        initializeBoardTiles.InitializeBoard();
        spawnGenerals.SpawnGeneralProcedure();
    }

    public void FillHand()
    {
        fillHand.FillHandWithReplaceCards();
    }
}
