using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] public GameObject[] tiles = new GameObject[45];
    public GameObject[,] tiles2D = new GameObject[5,9];

    int counter = 0;

    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log(tiles2D[counter,0]);
            counter += 1;
        }
    }
}
