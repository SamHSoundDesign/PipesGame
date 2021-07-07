using System.Collections.Generic;
using UnityEngine;

public class GameBoardObjectController : Controllers, IUnitys
{
    private List<Pipe> pipeList;
    public GameObject bentPipePrefab;
    public GameObject straightPipePrefab;

    private int selectedPipeID;
    public int SelectedPipeID
    {
        get
        {
            return selectedPipeID;
        }
        set
        {
            if (value > pipeList.Count)
            {
                selectedPipeID = 0;
            }
            else if (value < 0)
            {
                selectedPipeID = pipeList.Count;
            }
            else
            {
                selectedPipeID = value;
            }
        }
    }
    public Pipe selectedPipe;


    public GameBoardObjectController(GameController gameController , GameObject bentPipePrefab , GameObject straightPipePrefab)
    {
        pipeList = new List<Pipe>();
        this.gameController = gameController;
        this.bentPipePrefab = bentPipePrefab;
        this.straightPipePrefab = straightPipePrefab;
        SelectedPipeID = 0;
    }

    public void AStarts()
    {
        selectedPipe = pipeList[SelectedPipeID];
        selectedPipe.SelectPipe();
    }

    public void BUpdates()
    {
      
    }

    public void CFixedUpdates()
    {
      
    }

    public GameObject InstantiatePipeObject(GameObject prefab , Vector3 position )
    {
        return gameController.InstantiateGameBoardObjectObject(prefab, position);

    }

    public void AddToPipeList(Pipe pipe)
    {
        pipeList.Add(pipe);
        
    }

    public void SelectPipeAbove()
    {
      
        SelectPipe(3    );
    }

    public void SelectPipeBelow()
    {
        SelectPipe(-3);
    }

    public void SelectPipeRight()
    {
        
        SelectPipe(1);
    }

    public void SelectPipeLeft()
    {
       
        SelectPipe(-1);
    }

    private void SelectPipe(int direction)
    {

        selectedPipe.UnselectPipe();
        SelectedPipeID += direction;
        selectedPipe = pipeList[SelectedPipeID];
        selectedPipe.SelectPipe();
    }



}
