using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pipe : GameBoardObjects
{
    protected GameBoardObjectController pipeController;
    public bool isSelected;
    public int rotationindex = 0;
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

    public GameObject pipePrefab;
    
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

    public void SetUpPipeObject(GameBoardObjectController pipeController, int tileID, int[] tileGridID)
    {
        this.pipeController = pipeController;
        SetUpGameBoardObject(tileID, tileGridID);
    }

    public void CreateGameBoardObject()
    {

        gameBoardObject = pipeController.InstantiatePipeObject(pipePrefab, gameBoardObjectPosition);
        Debug.Log(gameBoardObject);

        anim = gameBoardObject.GetComponent<Animator>();

        this.pipeController.AddToPipeList(this);
    }

    public void RotatePipe()
    {

        switch (Rotationindex)
        {
            case 0:
                gameBoardObject.transform.rotation = Quaternion.Euler(0, 0, -90);
                RotatePorts();
                break;
            case 1:
                gameBoardObject.transform.rotation = Quaternion.Euler(0, 0, -180);
                RotatePorts();
                break;
            case 2:
                gameBoardObject.transform.rotation = Quaternion.Euler(0, 0, -270);
                RotatePorts();
                break;
            case 3:
                gameBoardObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                RotatePorts();
                break;
        }

        Rotationindex++;
        
  
    }

    private void RotatePorts()
    {
        //PortSideA++;
        //PortSideB++;
    }

}

    


