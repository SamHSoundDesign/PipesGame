using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileController : IUnitys
{
    private List<Tile> tileList;
    private GameController gameController;
    private PipeController pipeController;
    
    
    public TileController(GameController gameController , PipeController  pipeController)
    {
        tileList = new List<Tile>();
        this.gameController = gameController;
        this.pipeController = pipeController;
        
    }

    public void AStarts()
    {
        foreach (Tile tile in tileList)
        {
            tile.ConvertTileToPipe(pipeController);
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
