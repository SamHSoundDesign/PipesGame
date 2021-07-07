using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDataGroup : MonoBehaviour , IUnitys
{
    
    public List<TileData> tileDatasInGroup;
    private TileController tileController;
   
    private int tileID;
   
    public void AStarts()
    {
        
    }

    public void BUpdates()
    {
        
    }

    public void CFixedUpdates()
    {
        
    }

    public void ManualStart(TileController tileController)
    {
        tileID = 0;
        this.tileController = tileController;


        foreach (TileData tileData in tileDatasInGroup)
        {
            new Tile(tileController , tileData.pipeType , tileID);
            tileID++;
          
        }
    }
}
