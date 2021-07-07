using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bent : Pipe
{
    private static int bentCounter;
    public  int BentCounter
    {
        get
        {
            return bentCounter;
        }
        private set
        {
            bentCounter = value;
        }
    }

    public Bent(int tileID, int[] tileGridID  , GameBoardObjectController gameBoardObjectController)
    {
        pipePrefab = gameBoardObjectController.bentPipePrefab;
        isSelectable = true;

        SetUpGameBoardObject(tileID, tileGridID);
        CreateGameBoardObjectPipe(gameBoardObjectController);

        BentCounter++;
    }

    
}
