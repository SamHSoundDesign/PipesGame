using UnityEngine;

public class Block : GameBoardObjects
{
    private BlockController blockController;
    private GameObject blockPrefab;
      public Block(int tileID , int[] tileGridID , Vector3 blockPosition , BlockController blockController)
    {
        gameBoardObjectPosition = blockPosition;
        //this.blockController = blockController;
        blockPrefab = blockController.blockPrefab;
        base.tileID = tileID;
        base.tileGridID = tileGridID;
        gameBoardObject = blockController.InstantiateBlockObject(blockPrefab, gameBoardObjectPosition);
       
    }
}
