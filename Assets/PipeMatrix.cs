using System;
using UnityEngine;

public class PipeMatrix
{
    private int matrixWidth;

    public PipeMatrix()
    {
        matrixWidth = 4;
    }


    public Vector2 DefinePositionInMatrix(int pipeIndex)
    {

        //Vector2 vec = new Vector2(DefineX(pipeIndex), DefineY(pipeIndex));
        Vector2 vec = new Vector2(13,5);

        return vec;

    }

  // 3 = (

    private int DefineX(int pipeIndex)
    {
        int n = 0;

        for (int i = 0; i < matrixWidth; i++)
        {
            if(pipeIndex % matrixWidth == i)
            {
                n = i;
                break;
            }
        }
       
        return n;
    }

    private int DefineY(int pipeIndex)
    {
        int n = pipeIndex / matrixWidth;
        return n;
    }
}
