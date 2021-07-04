using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight : Pipe
{
    public static int straightCounter;
    public Straight()
    {

    }

    public Straight(GameObject pipeObject)
    {
        this.pipeObject = pipeObject;
        pipeCount++;
        straightCounter++;
    }

    public Straight(GameObject pipeObject , PipeType pipeType)
    {
        this.pipeObject = pipeObject;
        this.pipeType = pipeType;
        pipeCount++;
        straightCounter++;
    }
}

