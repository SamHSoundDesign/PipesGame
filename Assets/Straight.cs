using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight : Pipe
{
    private static int straightCounter;
    public int StraightCounter
    {
        get
        {
            return straightCounter;
        }
        private set
        {
            straightCounter = value;
        }
    }
    
    public Straight(int tileID , int[] tileGridID , GameBoardObjectController gameBoardObjectController)
    {
        pipePrefab = gameBoardObjectController.straightPipePrefab;
        isSelectable = true;

        SetUpPipeObject(tileID, tileGridID);
        CreateGameBoardObjectPipe(gameBoardObjectController);


        StraightCounter++;
    }

    
}

