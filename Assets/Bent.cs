using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bent : Pipe
{
    public static int bentCounter;
    

    public Bent()
        : this(null)
    {
       
}

    public Bent(GameObject pipeObject)
        : this(pipeObject , PipeType.Bent)
    {
     
    }

    public Bent(GameObject pipeObject , PipeType pipeType)
    {
        this.pipeObject = pipeObject;
        this.pipeType = pipeType;
        pipeCount++;
        bentCounter++;
        anim = this.pipeObject.GetComponent<Animator>();
        PortSideA = 1;
        PortSideB = 2;
        pipeMatrix = gameController.pipeMatrix;
        pipeMatrixPosition =  pipeMatrix.DefinePositionInMatrix(pipeID);
    }
}
