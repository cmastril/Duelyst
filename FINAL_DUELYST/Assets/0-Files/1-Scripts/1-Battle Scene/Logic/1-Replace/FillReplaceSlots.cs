using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillReplaceSlots : MonoBehaviour
{
    [SerializeField] private Replace replace;
    [SerializeField] private Deck deck;

    public void FillReplaceSlotsFromDeck()
    {
        GameObject tempCard = deck.DrawCard();
        replace.cardSlot1.GetComponent<ReplaceSlot>().setCurrentCard(tempCard);

        tempCard = deck.DrawCard();
        replace.cardSlot2.GetComponent<ReplaceSlot>().setCurrentCard(tempCard);

        tempCard = deck.DrawCard();
        replace.cardSlot3.GetComponent<ReplaceSlot>().setCurrentCard(tempCard);

        tempCard = deck.DrawCard();
        replace.cardSlot4.GetComponent<ReplaceSlot>().setCurrentCard(tempCard);

        tempCard = deck.DrawCard();
        replace.cardSlot5.GetComponent<ReplaceSlot>().setCurrentCard(tempCard);
    }
}
