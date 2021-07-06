using UnityEngine;

public class Block : GameBoardObjects
{
    private BlockController blockController;
    private GameObject blockPrefab;
      public Block(Vector3 blockPosition , BlockController blockController)
    {
        gameBoardObjectPosition = blockPosition;
        this.blockController = blockController;
        blockPrefab = blockController.blockPrefab;
        gameBoardObject = blockController.InstantiateBlockObject(blockPrefab, gameBoardObjectPosition);
       
    }
}
