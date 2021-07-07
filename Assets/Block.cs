using UnityEngine;

public class Block : GameBoardObjects
{
    private BlockController blockController;
    private GameObject blockPrefab;
      public Block(int tileID , int[] tileGridID , BlockController blockController)
    {
        
        //this.blockController = blockController;
        blockPrefab = blockController.blockPrefab;
        this.tileID = tileID;
        this.tileGridID = tileGridID;
        gameBoardObject = blockController.InstantiateBlockObject(blockPrefab, gameBoardObjectPosition);
       
    }
}
