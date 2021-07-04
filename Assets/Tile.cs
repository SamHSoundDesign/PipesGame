using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour , Iunitys
{
    public static GameController gameController;
    private GameObject straightPipe;
    private GameObject bentPipe;
    private GameObject pipeGameObject;
    private Vector3 tilePosition;
    private bool isSelected;
    private GameObject pipeOnject;
    private Animator anim;

    [SerializeField] private PipeType pipeType;

    public Tile()
    {
       
    }

    public void AStarts()
    {
        if (pipeType == PipeType.Straight)
        {
            pipeGameObject = gameController.straightPipePrefab;
        }
        else if (pipeType == PipeType.Bent)
        {
            pipeGameObject = gameController.bentPipePrefab;
        }

        pipeOnject = Instantiate(pipeGameObject, transform);

        tilePosition = transform.position;

    }
    public void BUpdates()
    {
        
    }

    public void CFixedUpdates()
    {

    }

    public void UnselectTile()
    {
        isSelected = false;
    }

    public void SelectTile()
    {
        isSelected = true; ;
    }


}

