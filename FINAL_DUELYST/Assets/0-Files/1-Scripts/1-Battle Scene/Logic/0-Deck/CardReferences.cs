using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReferences : MonoBehaviour
{
    public GameObject[] cardReferences = new GameObject[3]; 

    public GameObject idToCardObject(int index)
    {
        return cardReferences[index];
    }
}
