using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replace : MonoBehaviour
{
    [SerializeField] private LogicManager logicManager;
    [SerializeField] private Canvas replaceCanvas;
    [SerializeField] private Canvas uiCanvas;

    [SerializeField] private Deck deck;

    [SerializeField] public GameObject cardSlot1;
    [SerializeField] public GameObject cardSlot2;
    [SerializeField] public GameObject cardSlot3;
    [SerializeField] public GameObject cardSlot4;
    [SerializeField] public GameObject cardSlot5;

    public List<GameObject> selectedReplaceSlots = new List<GameObject>();

    public void AddToSelectedReplaceSlots(GameObject replaceSlot)
    {
        if (selectedReplaceSlots.Contains(replaceSlot))
        {
            selectedReplaceSlots.Remove(replaceSlot);
            replaceSlot.GetComponent<ReplaceSlot>().crossoutGameObject.SetActive(false);
        }
        else
        {
            selectedReplaceSlots.Add(replaceSlot);
            replaceSlot.GetComponent<ReplaceSlot>().crossoutGameObject.SetActive(true);
        }
    }

    public void FinalizeReplaceSlotSelection()
    {
        if (selectedReplaceSlots.Count <= 2)
        {
            GameObject[] slotsToReplace = selectedReplaceSlots.ToArray();

            for (int i = 0; i < slotsToReplace.Length; i++)
            {
                GameObject currentSlot = slotsToReplace[i];

                GameObject oldCard = currentSlot.GetComponent<ReplaceSlot>().currentCard;
                GameObject newCard = deck.DrawCard();

                deck.AddCard(oldCard);

                currentSlot.GetComponent<ReplaceSlot>().setCurrentCard(newCard);
            }

            logicManager.FillHand();

            replaceCanvas.gameObject.SetActive(false);
            uiCanvas.gameObject.SetActive(true);
        }
    }
}
