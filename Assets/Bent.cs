using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bent : Pipe
{
    public static int bentCounter;

    public Bent(int pipeId, Vector3 pipePosition , PipeController pipeController)
    {
        this.pipeId = pipeId;
        this.pipePosition = pipePosition;
        this.pipeController = pipeController;
        gameController = pipeController.gameController;
        //Need to fix the counter
        bentCounter++;
        pipePrefab = this.pipeController.bentPipePrefab;
        pipeObject = this.pipeController.InstantiatePipeObject(pipePrefab, this.pipePosition);
        anim = pipeObject.GetComponent<Animator>();
        this.pipeController.AddToPipeList(this);
        
    }
}
