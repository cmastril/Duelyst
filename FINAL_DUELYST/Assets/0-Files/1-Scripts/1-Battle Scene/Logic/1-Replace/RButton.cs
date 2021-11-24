using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RButton : MonoBehaviour
{
    [SerializeField] private Replace replace;

    private void Start()
    {
        replace = GameObject.FindGameObjectWithTag("Replace").GetComponent<Replace>();
    }

    public void RButtonPress()
    {
        replace.FinalizeReplaceSlotSelection();
    }
}
