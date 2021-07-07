using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
   
    public int tileID;
    
    public GameBoardObjectTypes gameBoardObjectType;

    private TileController tileController;

    public int[] tileGridID = new int[2];

    public Tile(TileController tileController , GameBoardObjectTypes gameBoardObjectType , int tileID)
    {
        this.tileController = tileController;
        this.gameBoardObjectType = gameBoardObjectType;
        this.tileID = tileID;
        this.tileGridID = tileController.ConverTileIdTo2DArray(tileID);
        this.tileController.AddToTileList(this);
        //Debug.Log(@$"Tile ID {tileID} has tile Grid id[0] = {tileGridID[0]} and has tile gridid[1] = {tileGridID[1]}");
    }

    public void CreateGameBoardObject(GameBoardObjectController gameBoardObjectController, BlockController blockController)
    {
        
            if (gameBoardObjectType == GameBoardObjectTypes.Straight)
            {
                new Straight(tileID, tileGridID , gameBoardObjectController);
            }
            else if (gameBoardObjectType == GameBoardObjectTypes.Bent)
            {
               new Bent(tileID, tileGridID, gameBoardObjectController);
            }
            else if(gameBoardObjectType == GameBoardObjectTypes.Blank)
            {
                new Block(tileID, tileGridID, gameBoardObjectController);
            }
        
        
    }

   
}

