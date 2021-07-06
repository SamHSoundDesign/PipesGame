using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pipe 
{
    protected PipeController pipeController;
    protected GameController gameController;
   
  

    protected Vector3 pipePosition;
    public bool isSelected;
    public int rotationindex = 0;
    protected PipeType pipeType;
    public int Rotationindex
    {
        get
        {
            return rotationindex;
        }
        set
        {
            if (value > 3)
            {
                rotationindex = 0;
            }
            else
            {
                rotationindex = value;
            }
        }
    }

    private int portSideA;
    public int PortSideA
    {
        get
        {
            return portSideA;
        }
        set
        {
            if (value > 3)
            {
                portSideA = 0;
            }
            else
            {
                portSideA = value;
            }
        }
    }
    private int portSideB;
    public int PortSideB
    {
        get
        {
            return portSideB;
        }
        set
        {
            if (value > 3)
            {
                portSideB = 0;
            }
            else
            {
                portSideB = value;
            }
        }
    }
    public bool isPowerSource;

    public PipeMatrix pipeMatrix;
    public Vector2 pipeMatrixPosition;
    protected int pipeId;

    protected GameObject pipeObject;
    protected GameObject pipePrefab;
    protected Animator anim;
    

    public void SelectPipe()
    {
        isSelected = true;
        anim.SetBool("isSelected", true);
        
    }

    public void UnselectPipe()
    {
        isSelected = false;
        anim.SetBool("isSelected", false);
    }

    public void RotatePipe()
    {

        switch (Rotationindex)
        {
            case 0:
                pipeObject.transform.rotation = Quaternion.Euler(0, 0, -90);
                RotatePorts();
                break;
            case 1:
                pipeObject.transform.rotation = Quaternion.Euler(0, 0, -180);
                RotatePorts();
                break;
            case 2:
                pipeObject.transform.rotation = Quaternion.Euler(0, 0, -270);
                RotatePorts();
                break;
            case 3:
                pipeObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                RotatePorts();
                break;
        }

        Rotationindex++;
        
  
    }

    private void RotatePorts()
    {
        PortSideA++;
        PortSideB++;
    }

    

    ////WIP
    //private void CheckNeighbours()
    //{
    //    if(PortSideA == 0 || PortSideB == 0)
    //    {
    //        //Check Pipe above
    //        if(gameController.allPipes[gameController.SelectedPipeIndex + 4].PortSideA == 2 || gameController.allPipes[gameController.SelectedPipeIndex + 4].PortSideB == 2)
    //        {
    //            if(gameController.allPipes[gameController.SelectedPipeIndex + 4].isPowerSource)
    //            {
    //                this.isPowerSource = true;
    //            }
    //        }
    //        else
    //        {
    //            this.isPowerSource = false;
    //        }
    //    }

    //    if (PortSideA == 1 || PortSideB == 1)
    //    {
    //        //Check Pipe right
    //    }


    //    if (PortSideA == 2 || PortSideB == 2)
    //    {
    //        //Check Pipe below
    //    }

    //    if (PortSideA == 3 || PortSideB == 3)
    //    {
    //        //Check Pipe Left
    //    }

    //}
}

    


