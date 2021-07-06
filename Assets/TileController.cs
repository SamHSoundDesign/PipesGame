using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileController : Controllers , IUnitys
{
    private List<Tile> tileList;
    public PipeController pipeController;
    public BlockController blockController;



    public TileController(GameController gameController , PipeController  pipeController , BlockController blockController)
    {
        tileList = new List<Tile>();
        base.gameController = gameController;
        this.pipeController = pipeController;
        this.blockController = blockController;
        
    }

    public void AStarts()
    {
        foreach (Tile tile in tileList)
        {
            tile.ConvertTileToGameBoardObject(pipeController);
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
}
