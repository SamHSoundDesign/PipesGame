using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour, Iunitys
{
    public static GameController gameController;
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
            Debug.Log($@"Total pipes == {Pipe.pipeCount}, Bent pipes == {Bent.bentCounter} and Straight pipes == {Straight.straightCounter}");
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


    }

    public void CFixedUpdates()
    {

    }

   
}
 
