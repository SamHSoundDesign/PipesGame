using System.Collections;
using UnityEngine;



public class TileData : MonoBehaviour, Iunitys
{
    private Vector3 tilePosition;
    [SerializeField] private PipeType pipeType;
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
