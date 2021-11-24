using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChecker : MonoBehaviour
{
    [SerializeField] private Canvas replaceCanvas;
    [SerializeField] private Canvas mainUICanvas;

    public void StartCheckerProcedure()
    {
        replaceCanvas.gameObject.SetActive(true);
        mainUICanvas.gameObject.SetActive(false);
    }
}
