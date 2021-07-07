using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : IUnitys
{
    private GameController gameController;
    private GameBoardObjectController gameBoardObjectController;

    public Controls(GameController gameController)
    {
        this.gameController = gameController;
        this.gameBoardObjectController = gameController.gameBoardObjectController;

    }
    public void AStarts()
    {

    }

    public void BUpdates()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameBoardObjectController.SelectPipeAbove();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            gameBoardObjectController.SelectPipeLeft();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameBoardObjectController.SelectPipeBelow();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameBoardObjectController.SelectPipeRight();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameController.gameBoardObjectController.selectedPipe.RotatePipe();
        }
          
    }

    public void CFixedUpdates()
    {

    }

   
}
 
