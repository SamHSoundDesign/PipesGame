using UnityEngine;

public class Block : GameBoardObject
{
    private GameObject blockPrefab;
    public Block(int tileID, int[] tileGridID, GameBoardObjectController gameBoardObjectController)
    {
        blockPrefab = gameBoardObjectController.blockPrefab;
        isSelectable = false;
        SetUpBlockObject(gameBoardObjectController , tileID, tileGridID);
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
        gameBoardObjectController.AddToAllBlockList(this);
    }

}
