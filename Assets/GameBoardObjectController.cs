using System.Collections.Generic;
using UnityEngine;

public class GameBoardObjectController : Controllers, IUnitys
{
    private List<GameBoardObject> allGameBoardObjects;
    private List<Pipe> allPipes;
    private List<Block> allBlocks;
    public GameObject bentPipePrefab;
    public GameObject straightPipePrefab;
    public GameObject blockPrefab;
    private GridController gridController;

    private int selectedPipeID;
    public int SelectedPipeID
    {
        get
        {
            return selectedPipeID;
        }
        set
        {
            if (value > allPipes.Count)
            {
                selectedPipeID = 0;
            }
            else if (value < 0)
            {
                selectedPipeID = allPipes.Count;
            }
            else
            {
                selectedPipeID = value;
            }
        }
    }
    public Pipe  selectedPipe;


    public GameBoardObjectController(GameController gameController , GameObject bentPipePrefab , GameObject straightPipePrefab , GridController gridController)
    {
        allGameBoardObjects = new List<GameBoardObject>();
        allPipes = new List<Pipe>();
        allBlocks = new List<Block>();
        this.gameController = gameController;
        this.bentPipePrefab = bentPipePrefab;
        this.straightPipePrefab = straightPipePrefab;
        this.gridController = gridController;
        SelectedPipeID = 0;
    }

    public void AStarts()
    {
        selectedPipe = allPipes[SelectedPipeID];
        selectedPipe.SelectPipe();
    }

    public void BUpdates()
    {
      
    }

    public void CFixedUpdates()
    {
      
    }

    public GameObject InstantiateGameBoardObject(GameObject prefab , Vector3 position )
    {
        return gameController.InstantiateGameBoardObjectObject(prefab, position);

    }

    public void AddToAllGameBoardObjectsList(GameBoardObject gameBoardObjects)
    {
        allGameBoardObjects.Add(gameBoardObjects);  
    }

    public void AddToAllPipesList(Pipe pipe)
    {
        allPipes.Add(pipe);
    }

    public void AddToAllBlockList(Block block)
    {
        allBlocks.Add(block);
    }

    public void SelectPipeAbove()
    {
        ChangeSelectedPipe(gridController.xWidth);
    }

    public void SelectPipeBelow()
    {
        ChangeSelectedPipe(gridController.xWidth * -1);
    }

    public void SelectPipeRight()
    {
        ChangeSelectedPipe(1);
    }

    public void SelectPipeLeft()
    {
        ChangeSelectedPipe(-1);
    }

    private void ChangeSelectedPipe(int direction)
    {
        selectedPipe.UnselectPipe();
        SelectedPipeID += direction;
        selectedPipe = allPipes[SelectedPipeID];
        selectedPipe.SelectPipe();
    }



}
