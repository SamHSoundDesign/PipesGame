using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour, Iunitys
{
    public static GameController gameController;

    public Controls( )
    {
       
    }
    public void AStarts()
    {

    }

    public void BUpdates()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gameController.SelectNextTile();
            
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
            gameController.allPipes[gameController.SelectedPipeIndex].RotatePipe();
        }


    }

    public void CFixedUpdates()
    {

    }

   
}
 
