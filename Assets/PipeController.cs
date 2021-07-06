using System.Collections.Generic;
using UnityEngine;

public class PipeController : IUnitys
{
    private List<Pipe> pipeList;
    public GameController gameController;
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
            if(value < pipeList.Count)
            {
                selectedPipeID = value;
            }
            else
            {
                selectedPipeID = 0;
            }
        }
    }
    public Pipe selectedPipe;

    public PipeController(GameController gameController , GameObject bentPipePrefab , GameObject straightPipePrefab)
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
        return gameController.InstantiatePipeObject(prefab, position);

    }

    public void AddToPipeList(Pipe pipe)
    {
        pipeList.Add(pipe);
        
    }

    public void SelectNextTile()
    {
        selectedPipe.UnselectPipe();
        SelectedPipeID++;
        selectedPipe = pipeList[SelectedPipeID];
        selectedPipe.SelectPipe();
       

    }



}
