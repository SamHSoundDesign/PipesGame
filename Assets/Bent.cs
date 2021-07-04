using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bent : Pipe
{
    public static int bentCounter;
    public Bent()
    {

    }

    public Bent(GameObject pipeObject)
    {
        this.pipeObject = pipeObject;
        pipeCount++;
        bentCounter++;
    }

    public Bent(GameObject pipeObject , PipeType pipeType)
    {
        this.pipeObject = pipeObject;
        this.pipeType = pipeType;
        pipeCount++;
        bentCounter++;
    }
}
