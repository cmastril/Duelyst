using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeBoardTiles : MonoBehaviour
{
    [SerializeField] private Board board;

    public void InitializeBoard()
    {
        GameObject[] tempTileArray = board.tiles;
        GameObject[,] tempTileArray2d = board.tiles2D;

        int currentColumn = 0;
        int tileIndex = 0;
        for (int i = 0; i < 45; i++)
        {
            GameObject currentTile = tempTileArray[i];

            if (tileIndex == 5)
            {
                tileIndex = 0;
                currentColumn += 1;
            }

            tempTileArray2d[tileIndex, currentColumn] = currentTile;

            Debug.Log((tileIndex, currentColumn));
            Debug.Log(currentTile);

            tileIndex += 1;
        }

        board.tiles2D = tempTileArray2d;
    }
}
