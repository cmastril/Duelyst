using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplaceSlot : MonoBehaviour
{
    [SerializeField] private Image displayedCardImage;
    [SerializeField] public GameObject crossoutGameObject;

    public GameObject currentCard;

    public void setCurrentCard(GameObject card)
    {
        currentCard = card;
    }

    public void displayCurrentCard()
    {
        displayedCardImage.sprite = currentCard.GetComponent<Card>().cardDisplaySprite;
    }
}
