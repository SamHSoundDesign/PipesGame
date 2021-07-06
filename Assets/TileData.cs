using System.Collections;
using UnityEngine;



public class TileData : MonoBehaviour, IUnitys
{
    public Vector3 tilePosition;
    public PipeType pipeType;
    public void AStarts()
    {
        tilePosition = transform.position;
    }

    public void BUpdates()
    {
       
    }

    public void CFixedUpdates()
    {
       
    }
}
