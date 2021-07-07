using UnityEngine;

public abstract class GameBoardObject 
{

    protected GameBoardObjectTypes gamBoardObjectType;
    protected Vector3 gameBoardObjectPosition;
    protected GameObject gameBoardObject;
    protected Animator anim;
    protected int tileID;
    protected int[] tileGridID;
    protected bool isSelectable;

    public  void SetUpGameBoardObject(int tileID, int[] tileGridID )
        
    {
        this.tileID = tileID;
        this.tileGridID = tileGridID;
        gameBoardObjectPosition.x = tileGridID[0];
        gameBoardObjectPosition.y = tileGridID[1];
        gameBoardObjectPosition.z = 0;
    }

    


}


    