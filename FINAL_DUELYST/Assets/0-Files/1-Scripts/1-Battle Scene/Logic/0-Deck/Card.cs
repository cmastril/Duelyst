using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] public Sprite cardDisplaySprite;
    [SerializeField] public int cardID;
    [SerializeField] public string owner;

    public void SetCardOwner(string newOwner)
    {
        owner = newOwner;
    }
}
