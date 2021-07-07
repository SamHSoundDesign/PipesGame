using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Pipe Prefabs
    public GameObject bentPipePrefab;
    public GameObject straightPipePrefab;
    public GameObject blockPrefab;

    //Grid details
    [SerializeField] private int xWidth;
    [SerializeField] private int unitsPerGrid;

      
    //Tile Group
    [SerializeField] private TileDataGroup tileDataGroup;

    private Controllers controllers;
    private GridController gridController;
    private TileController tileController;    
    public GameBoardObjectController gameBoardObjectController;
    public BlockController blockController;
    public Controls controls;

    void Start()
    {
        SetUpGameController();
        
    }


    void Update()
    {
        controls = new Controls(this);
        controls.BUpdates();
    }

    

    public GameObject InstantiateGameBoardObjectObject(GameObject prefab , Vector3 position)
    {
        GameObject newPipe = Instantiate(prefab , position , new Quaternion (0,0,0,0));
        return newPipe;
    }

    private void SetUpGameController()
        
    {
        gridController = new GridController(this , xWidth , unitsPerGrid);
        gameBoardObjectController = new GameBoardObjectController(this , bentPipePrefab , straightPipePrefab);
        tileController = new TileController(this , gameBoardObjectController, blockController , gridController);
        
        tileDataGroup.ManualStart(tileController);

        tileController.AStarts();

        gameBoardObjectController.AStarts();

       
    }



}
