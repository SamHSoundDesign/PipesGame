using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bent : Pipe
{
    public Bent(int tileID, int[] tileGridID  , GameBoardObjectController gameBoardObjectController)
    {
        pipePrefab = gameBoardObjectController.bentPipePrefab;
        isSelectable = true;

        SetUpGameBoardObject(tileID, tileGridID);
        CreateGameBoardObjectPipe(gameBoardObjectController);
    }

    
}
