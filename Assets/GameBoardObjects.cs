using UnityEngine;

public abstract class GameBoardObjects 
{

    protected GameBoardObjectTypes gamBoardObjectType;
    protected Vector3 gameBoardObjectPosition;
    protected GameObject gameBoardObject;
    protected Animator anim;
    protected int tileID;
    protected int[] tileGridID;
    protected bool isSelectable;

    public  void SetUpGameBoardObject(int tileID, int[] tileGridID)
        
    {
        this.tileID = tileID;
        this.tileGridID = tileGridID;
        this.gameBoardObjectPosition.x = tileGridID[0];
        this.gameBoardObjectPosition.y = tileGridID[1];
        this.gameBoardObjectPosition.z = 0;
    }

    


}


    