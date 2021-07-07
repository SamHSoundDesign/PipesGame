using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : IUnitys
{
    private GameController gameController;
    private GameBoardObjectController pipeController;

    public Controls(GameController gameController )
    {
        this.gameController = gameController;
        this.pipeController = gameController.pipeController;

    }
    public void AStarts()
    {

    }

    public void BUpdates()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            pipeController.SelectPipeAbove();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            pipeController.SelectPipeLeft();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            pipeController.SelectPipeBelow();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            pipeController.SelectPipeRight();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameController.pipeController.selectedPipe.RotatePipe();
        }


    }

    public void CFixedUpdates()
    {

    }

   
}
 
