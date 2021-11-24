using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayReplaceSlots : MonoBehaviour
{
    [SerializeField] private Replace replace;

    public void DisplayReplaceSlotCards()
    {
        replace.cardSlot1.GetComponent<ReplaceSlot>().displayCurrentCard();
        replace.cardSlot2.GetComponent<ReplaceSlot>().displayCurrentCard();
        replace.cardSlot3.GetComponent<ReplaceSlot>().displayCurrentCard();
        replace.cardSlot4.GetComponent<ReplaceSlot>().displayCurrentCard();
        replace.cardSlot5.GetComponent<ReplaceSlot>().displayCurrentCard();
    }
}
