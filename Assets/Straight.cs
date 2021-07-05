using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight : Pipe
{
    public static int straightCounter;

   

    public Straight()
        : this(null)
    {
       
    }

    public Straight(GameObject pipeObject)
        : this(pipeObject , PipeType.Straight)
    {
      
    }

    public Straight(GameObject pipeObject , PipeType pipeType)
    {
        this.pipeObject = pipeObject;
        this.pipeType = pipeType;
        pipeCount++;
        straightCounter++;
        anim = this.pipeObject.GetComponent<Animator>();
        PortSideA = 0;
        PortSideB = 2;
        pipeMatrix = Straight.gameController.pipeMatrix;
    }
}

