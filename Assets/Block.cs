using UnityEngine;

public class Block : GameBoardObject
{
    
    
    private GameObject blockPrefab;
      public Block(int tileID , int[] tileGridID , GameBoardObjectController gameBoardObjectController)
    {
        blockPrefab = gameBoardObjectController.blockPrefab;
        SetUpGameBoardObject(tileID, tileGridID);
        isSelectable = false;
        this.tileID = tileID;
        this.tileGridID = tileGridID;
        gameBoardObject = gameBoardObjectController.InstantiateGameBoardObject(blockPrefab, gameBoardObjectPosition);
    }

    public void SetUpBlockObject(GameBoardObjectController gameBoardObjectController, int tileID, int[] tileGridID)
    {
        SetUpGameBoardObject(tileID, tileGridID);
        CreateGameBoardObjectBlock(gameBoardObjectController);
    }

    public void CreateGameBoardObjectBlock(GameBoardObjectController gameBoardObjectController)
    {

        gameBoardObject = gameBoardObjectController.InstantiateGameBoardObject(blockPrefab, gameBoardObjectPosition);

        anim = gameBoardObject.GetComponent<Animator>();

        gameBoardObjectController.AddToAllGameBoardObjectsList(this);
    }

}
