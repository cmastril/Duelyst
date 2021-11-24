using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillHand : MonoBehaviour
{
    [SerializeField] private Hand hand;
    [SerializeField] private Replace replace;

    public void FillHandWithReplaceCards()
    {
        ReplaceSlot replaceCardSlot = replace.cardSlot1.GetComponent<ReplaceSlot>();
        HandSlot handCardSlot = hand.handSlot1.GetComponent<HandSlot>();
        TransferFromReplaceToHandSlot(replaceCardSlot, handCardSlot);

        replaceCardSlot = replace.cardSlot2.GetComponent<ReplaceSlot>();
        handCardSlot = hand.handSlot2.GetComponent<HandSlot>();
        TransferFromReplaceToHandSlot(replaceCardSlot, handCardSlot);

        replaceCardSlot = replace.cardSlot3.GetComponent<ReplaceSlot>();
        handCardSlot = hand.handSlot3.GetComponent<HandSlot>();
        TransferFromReplaceToHandSlot(replaceCardSlot, handCardSlot);

        replaceCardSlot = replace.cardSlot4.GetComponent<ReplaceSlot>();
        handCardSlot = hand.handSlot4.GetComponent<HandSlot>();
        TransferFromReplaceToHandSlot(replaceCardSlot, handCardSlot);

        replaceCardSlot = replace.cardSlot5.GetComponent<ReplaceSlot>();
        handCardSlot = hand.handSlot5.GetComponent<HandSlot>();
        TransferFromReplaceToHandSlot(replaceCardSlot, handCardSlot);
    }

    private void TransferFromReplaceToHandSlot(ReplaceSlot replaceCardSlot, HandSlot handCardSlot)
    {
        GameObject curCard = replaceCardSlot.currentCard;
        handCardSlot.setCurrentCard(curCard);
        handCardSlot.displayCurrentCard();
    }
}
