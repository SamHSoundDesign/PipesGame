using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : Iunitys
{
    public static GameController gameController;
    private GameObject straightPipe;
    private GameObject bentPipe;
    private GameObject pipeGameObject;
    private Vector3 tilePosition;
    private bool isSelected;
    private GameObject pipeObject;
    private Animator anim;
    private Pipe pipe;
    private static int tileCounter;
    private int tileID;
    

    [SerializeField] private PipeType pipeType;

    private TileController tileController;

    public Tile(TileController tileController)
    {
        this.tileController = tileController;
        tileCounter++;
        tileID = tileCounter;
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

        pipeObject = Instantiate(pipeGameObject, transform);

        if (pipeType == PipeType.Straight)
        {
            pipe = new Straight(pipeObject , pipeType);
            gameController.allPipes.Add(pipe);

        }
        else if (pipeType == PipeType.Bent)
        {
            pipe = new Bent(pipeObject , pipeType);
            gameController.allPipes.Add(pipe);
        }

        tilePosition = transform.position;

    }
    public void BUpdates()
    {
        
    }

    public void CFixedUpdates()
    {

    }

    //public void UnselectTile()
    //{
    //    isSelected = false;
    //}

    //public void SelectTile()
    //{
    //    isSelected = true; ;
    //}


}

