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
        this.pipePosition = pipePosition;
        this.pipeController = pipeController;
        gameController = pipeController.gameController;
        StraightCounter++;
        pipePrefab = this.pipeController.straightPipePrefab;
        pipeObject = this.pipeController.InstantiatePipeObject(pipePrefab, this.pipePosition);
        anim = pipeObject.GetComponent<Animator>();
        this.pipeController.AddToPipeList(this);
    }

    
}

