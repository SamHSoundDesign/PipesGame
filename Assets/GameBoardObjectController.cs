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


    public GameBoardObjectController(GameController gameController , GameObject bentPipePrefab , GameObject straightPipePrefab)
    {
        allGameBoardObjects = new List<GameBoardObject>();
        allPipes = new List<Pipe>();
        allBlocks = new List<Block>();
        this.gameController = gameController;
        this.bentPipePrefab = bentPipePrefab;
        this.straightPipePrefab = straightPipePrefab;
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
        selectedPipe = allPipes[SelectedPipeID];
        selectedPipe.SelectPipe();
    }



}
