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
    
    public Straight(int pipeId , Vector3 pipePosition , PipeController pipeController)
    {
        this.pipeId = pipeId;
        this.gameBoardObjectPosition = pipePosition;
        this.pipeController = pipeController;
        StraightCounter++;
        pipePrefab = this.pipeController.straightPipePrefab;
        gameBoardObject = this.pipeController.InstantiatePipeObject(pipePrefab, base.gameBoardObjectPosition);
        anim = gameBoardObject.GetComponent<Animator>();
        this.pipeController.AddToPipeList(this);
    }

    
}

