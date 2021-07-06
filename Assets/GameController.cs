using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Pipe Prefabs
    public GameObject bentPipePrefab;
    public GameObject straightPipePrefab;
    public GameObject blockPrefab;
      
    //Tile Group
    [SerializeField] private TileDataGroup tileDataGroup;

    private Controllers controllers;
    private TileController tileController;    
    public PipeController pipeController;
    public BlockController blockController;
    private Controls controls;

    void Start()
    {
        SetUpGameController();
        
    }


    void Update()
    {
        controls.BUpdates();
    }

    

    public GameObject InstantiateGameBoardObjectObject(GameObject prefab , Vector3 position)
    {
        GameObject newPipe = Instantiate(prefab , position , new Quaternion (0,0,0,0));
        return newPipe;
    }

    private void SetUpGameController()
        
    {   
        pipeController = new PipeController(this, bentPipePrefab, straightPipePrefab);
        blockController = new BlockController(this);
        tileController = new TileController(this, pipeController , blockController);
        

        tileDataGroup.ManualStart(tileController);

        tileController.AStarts();

        //pipeMatrix = new PipeMatrix();
        pipeController.AStarts();

        controls = new Controls(this);
    }



}
