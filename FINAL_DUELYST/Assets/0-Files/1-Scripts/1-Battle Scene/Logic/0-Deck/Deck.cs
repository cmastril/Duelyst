using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] public GameObject general;
    public List<GameObject> deck = new List<GameObject>();

    public GameObject DrawCard()
    {
        int deckCardCount = deck.Count;
        int randomCardIndex = Random.Range(0,deckCardCount);

        GameObject returnCard = deck.ToArray()[randomCardIndex];
        deck.Remove(returnCard);

        return returnCard;
    }

    public void AddCard(GameObject unitToAdd)
    {
        deck.Add(unitToAdd);
    }
}
