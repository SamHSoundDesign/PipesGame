using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileController : Controllers , IUnitys
{
    private List<Tile> tileList;
    public GameBoardObjectController gameBoardObjectController;
    private int[] tileGridID;
    private GridController gridController;

    public TileController(GameController gameController , GameBoardObjectController gameBoardObjectController , GridController gridController)
    {
        tileList = new List<Tile>();
        base.gameController = gameController;
        this.gameBoardObjectController = gameBoardObjectController;
        this.gridController = gridController;
    }

    public void AStarts()
    {
        foreach (Tile tile in tileList)
        {
            tile.CreateGameBoardObject(gameBoardObjectController);
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
