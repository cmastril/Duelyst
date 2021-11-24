using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputHanlder : MonoBehaviour
{
    [SerializeField] private GameObject currentLookObject;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject selection = hit.transform.gameObject;

            if (selection.tag == "HandSlot")
            {
                Debug.Log("Currently hovering a hand slot");
            }

            currentLookObject = selection;
        }
    }
}
