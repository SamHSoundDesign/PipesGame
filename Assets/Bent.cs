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

    public Bent(int tileID, int[] tileGridID  , GameBoardObjectController pipeController)
    {
        pipePrefab = pipeController.bentPipePrefab;
        isSelectable = true;
        
        SetUpPipeObject(pipeController , tileID , tileGridID);
        CreateGameBoardObject();

        BentCounter++;
    }

    
}
