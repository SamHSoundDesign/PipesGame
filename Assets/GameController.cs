using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Pipe Prefabs
    public GameObject bentPipePrefab;
    public GameObject straightPipePrefab;
      
    //Tile Group
    [SerializeField] private TileDataGroup tileDataGroup;
    
    private TileController tileController;    
    public PipeController pipeController;
    private Controls controls;

    void Start()
    {
        SetUpGameController();
        
    }


    void Update()
    {
        controls.BUpdates();
    }

    

    public GameObject InstantiatePipeObject(GameObject prefab , Vector3 position)
    {
        GameObject newPipe = Instantiate(prefab , position , new Quaternion (0,0,0,0));
        return newPipe;
    }

    private void SetUpGameController()
    {
        pipeController = new PipeController(this, bentPipePrefab, straightPipePrefab);
        tileController = new TileController(this, pipeController);
        

        tileDataGroup.ManualStart(tileController);

        tileController.AStarts();

        //pipeMatrix = new PipeMatrix();
        pipeController.AStarts();

        controls = new Controls(this);
    }



}
