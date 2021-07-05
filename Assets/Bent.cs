using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bent : Pipe
{
    public static int bentCounter;
    

    public Bent()
    {
        PortSideA = 1;
        PortSideB = 2;
}

    public Bent(GameObject pipeObject)
    {
        this.pipeObject = pipeObject;
        pipeCount++;
        bentCounter++;
        anim = this.pipeObject.GetComponent<Animator>();
        PortSideA = 1;
        PortSideB = 2;
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
    }
}
