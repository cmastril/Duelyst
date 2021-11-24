using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private SpriteRenderer displayedCardImage;

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
