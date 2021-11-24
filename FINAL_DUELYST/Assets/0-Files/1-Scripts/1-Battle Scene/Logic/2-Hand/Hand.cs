using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField] public GameObject handSlot1;
    [SerializeField] public GameObject handSlot2;
    [SerializeField] public GameObject handSlot3;
    [SerializeField] public GameObject handSlot4;
    [SerializeField] public GameObject handSlot5;
    [SerializeField] public GameObject handSlot6;

    [SerializeField] public GameObject[] allHandSlots = new GameObject[6];

    private void Start()
    {
        allHandSlots[0] = handSlot1;
        allHandSlots[1] = handSlot2;
        allHandSlots[2] = handSlot3;
        allHandSlots[3] = handSlot4;
        allHandSlots[4] = handSlot5;
        allHandSlots[5] = handSlot6;
    }
}
