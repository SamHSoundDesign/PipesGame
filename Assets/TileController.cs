using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileController : Controllers , IUnitys
{
    private List<Tile> tileList;
    public GameBoardObjectController pipeController;
    public BlockController blockController;
    private int[] tileGridID;
    private GridController gridController;

    public TileController(GameController gameController , GameBoardObjectController  pipeController , BlockController blockController , GridController gridController)
    {
        tileList = new List<Tile>();
        base.gameController = gameController;
        this.pipeController = pipeController;
        this.blockController = blockController;
        this.gridController = gridController;
       

    }

    public void AStarts()
    {
        foreach (Tile tile in tileList)
        {
            
            tile.CreateGameBoardObject(pipeController , blockController);
        }

        
    }

    public void BUpdates()
    {

    }

    public void CFixedUpdates()
    {
       
    }

    public void AddToTileList(Tile tile)
    {
        tileList.Add(tile); 
    }

    public int[] ConverTileIdTo2DArray(int tileId)
    {
        return gridController.ConvertTileIdTo2DArray(tileId);
        
    }
}
