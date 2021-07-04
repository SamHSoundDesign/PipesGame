using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pipe
{
    private bool isPipeEndAConnected;
    private bool isPipeEndNConnected;
    private bool isBothPipeEndsConnected;

    private GameObject pipeObject;

    public Pipe()
    {

    }

    public Pipe(GameObject pipeObject)
    {
        this.pipeObject = pipeObject;
    }

}
