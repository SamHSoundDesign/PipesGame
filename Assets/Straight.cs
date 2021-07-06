using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight : Pipe
{
    private int straightCounter;
    
    public Straight(int pipeId , Vector3 pipePosition , PipeController pipeController)
    {
        this.pipeId = pipeId;
        this.pipePosition = pipePosition;
        this.pipeController = pipeController;
        this.gameController = pipeController.gameController;
        
        //Need to fix the counter
        straightCounter++;
        this.pipePrefab = this.pipeController.straightPipePrefab;
        this.pipeObject = this.pipeController.InstantiatePipeObject(pipePrefab, this.pipePosition);
        anim = pipeObject.GetComponent<Animator>();
        this.pipeController.AddToPipeList(this);
    }

    
}

