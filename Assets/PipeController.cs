using System.Collections.Generic;
using UnityEngine;

public class PipeController : Iunitys
{
    private List<Pipe> allPipes;
    private int pipeIndex;
    private GameController gameController;
    public GameObject bentPipePrefab;
    public GameObject straightPipePrefab;

    public PipeController(GameController gameController)
    {
        this.gameController = gameController;
        foreach (Pipe pipe in allPipes)
        {
            //pipe.AStarts();
        }
    }

    public void AStarts()
    {
      
    }

    public void BUpdates()
    {
      
    }

    public void CFixedUpdates()
    {
      
    }
}
