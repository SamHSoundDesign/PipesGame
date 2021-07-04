using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pipe
{
    private bool isPipeEndAConnected;
    private bool isPipeEndNConnected;
    private bool isBothPipeEndsConnected;
    public static int pipeCount;
    protected PipeType pipeType;

    protected GameObject pipeObject;

    public Pipe()
    {

    }

    public Pipe(GameObject pipeObject)
    {
        this.pipeObject = pipeObject;
        pipeCount++;
        
    }

    public Pipe(GameObject pipeObject , PipeType pipeType)
    {
        this.pipeObject = pipeObject;
        pipeCount++;
        this.pipeType = pipeType;
    }

}
