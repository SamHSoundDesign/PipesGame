using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    private Vector3 tilePosition;
    public int tileID;
    
    public GameBoardObjectTypes gameBoardObjectType;

    private TileController tileController;
    private BlockController blockController;
    private GridController gridController;

    public int[] tileGridID = new int[2];

    public Tile(TileController tileController , GameBoardObjectTypes pipeType , Vector3 tilePosition , int tileID)
    {
        this.tileController = tileController;
        this.tilePosition = tilePosition;
        this.gameBoardObjectType = pipeType;
        this.tileID = tileID;
        this.tileController.AddToTileList(this);
        this.tileGridID = tileController.ConverTileIdTo2DArray(tileID);
        //Debug.Log(@$"Tile ID {tileID} has tile Grid id[0] = {tileGridID[0]} and has tile gridid[1] = {tileGridID[1]}");
    }

    public void CreateGameBoardObject(PipeController pipeController , BlockController blockController)
    {
        
            if (gameBoardObjectType == GameBoardObjectTypes.Straight)
            {
                new Straight(tileID, tileGridID , pipeController);
            }
            else if (gameBoardObjectType == GameBoardObjectTypes.Bent)
            {
                new Bent(tileID, tileGridID, pipeController);
            }
            else if(gameBoardObjectType == GameBoardObjectTypes.Blank)
            {
                new Block(tileID, tileGridID, tilePosition, blockController);
            }
        
        
    }

   
}

