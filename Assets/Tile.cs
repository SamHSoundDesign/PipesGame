using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : IUnitys
{
    private Vector3 tilePosition;
    private static int tileCounter;
    public int TileCounter
    {
        get
        {
            return tileCounter;
        }
        set
        {
            tileCounter = value;
        }
    }
    private int tileID;
    public GameBoardObjectTypes gameBoardObjectType;

    private TileController tileController;
    private BlockController blockController;

    public Tile(TileController tileController , GameBoardObjectTypes pipeType , Vector3 tilePosition)
    {
        this.tileController = tileController;
        this.tilePosition = tilePosition;
        this.gameBoardObjectType = pipeType;
        blockController = tileController.blockController;
        TileCounter++;
        tileID = tileCounter;
        this.tileController.AddToTileList(this);
    }

    public void ConvertTileToGameBoardObject(PipeController pipeController)
    {
        
            if (gameBoardObjectType == GameBoardObjectTypes.Straight)
            {
                new Straight(tileID, tilePosition , pipeController);
            }
            else if (gameBoardObjectType == GameBoardObjectTypes.Bent)
            {
                new Bent(tileID, tilePosition , pipeController);
            }
            else if(gameBoardObjectType == GameBoardObjectTypes.Blank)
            {
                new Block(tilePosition, blockController);
        }
        
        
    }

    public void AStarts()
    {
      
    }

    public void BUpdates()
    {
        
    }

    public void CFixedUpdates()
    {
        
    }
}

