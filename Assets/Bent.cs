using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bent : Pipe
{
    private static int bentCounter;
    public  int BentCounter
    {
        get
        {
            return bentCounter;
        }
        private set
        {
            bentCounter = value;
        }
    }

    public Bent(int pipeId, Vector3 pipePosition , PipeController pipeController)
    {
        this.pipeId = pipeId;
        gameBoardObjectPosition = pipePosition;
        this.pipeController = pipeController;
        BentCounter++;
        pipePrefab = this.pipeController.bentPipePrefab;
        gameBoardObject = this.pipeController.InstantiatePipeObject(pipePrefab, this.gameBoardObjectPosition);
        anim = gameBoardObject.GetComponent<Animator>();
        this.pipeController.AddToPipeList(this);
        
    }
}
