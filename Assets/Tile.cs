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
    public PipeType pipeType;

    private TileController tileController;

    public Tile(TileController tileController , PipeType pipeType , Vector3 tilePosition )
    {
        this.tileController = tileController;
        this.tilePosition = tilePosition;
        this.pipeType = pipeType;
        TileCounter++;
        tileID = tileCounter;
        this.tileController.AddToTileList(this);
    }

    public void ConvertTileToPipe(PipeController pipeController)
    {
        
            if (pipeType == PipeType.Straight)
            {
                new Straight(tileID, tilePosition , pipeController);
            }
            else if (pipeType == PipeType.Bent)
            {
                new Bent(tileID, tilePosition , pipeController);
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

