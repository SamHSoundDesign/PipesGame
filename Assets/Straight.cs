using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight : Pipe
{
   
    public Straight(int tileID , int[] tileGridID , GameBoardObjectController gameBoardObjectController)
    {
        pipePrefab = gameBoardObjectController.straightPipePrefab;
        isSelectable = true;

        SetUpPipeObject(tileID, tileGridID);
        CreateGameBoardObjectPipe(gameBoardObjectController);

    }

    
}

