using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : IUnitys
{
    private GameController gameController;

    public Controls(GameController gameController )
    {
        this.gameController = gameController;
    }
    public void AStarts()
    {

    }

    public void BUpdates()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gameController.pipeController.SelectNextTile();
            
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }

        if (Input.GetKeyDown(KeyCode.A))
        {

        }

        if (Input.GetKeyDown(KeyCode.S))
        {

        }

        if (Input.GetKeyDown(KeyCode.D))
        {

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            gameController.pipeController.selectedPipe.RotatePipe();
        }


    }

    public void CFixedUpdates()
    {

    }

   
}
 
