using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillDeck : MonoBehaviour
{
    [SerializeField] private GameObject testCommander;
    [SerializeField] private GameObject testUnit;
    [SerializeField] private GameObject testUnitBrightmoss;

    [SerializeField] private Deck deck;

    public void FillDeckWithTestUnits()
    {
        deck.general = testCommander;

        for (int i = 0; i < 39; i ++)
        {
            int randInt = Random.Range(0,2);

            if (randInt == 0)
            {
                deck.AddCard(testUnit);
            }
            else if (randInt == 1)
            {
                deck.AddCard(testUnitBrightmoss);
            }
        }
    }
}
