using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
      
    private GameController gameController;
    public GameObject bentPipePrefab;
    public GameObject straightPipePrefab;
    private static List<Tile> tileList;
    private Controls controls;
    [SerializeField] private TileGroup tileGroup;
    public PipeMatrix pipeMatrix;

    private int selectedPipeIndex;
    public int SelectedPipeIndex
    {
        get
        {
            return selectedPipeIndex;
        }
        set
        {
            if(value < allPipes.Count)
            {
                selectedPipeIndex = value;
            }
            else
            {
                selectedPipeIndex = 0;

            }
        }
    }
    private  Pipe selectedPipe;
    public  List<Pipe> allPipes = new List<Pipe>();
    public Tile selectedTile;
    

    public GameController()
    {
       
    }

    void Start()
    {
        SelectedPipeIndex = 0;
        tileList = new List<Tile>();
        pipeMatrix = new PipeMatrix();
       

        this.gameController = GetComponent<GameController>();
        controls = GetComponent<Controls>();
        //Controls.gameController = this.gameController;
        Tile.gameController = this.gameController;
        Pipe.gameController = this.gameController;

        tileList = tileGroup.tilesInGroup;

        foreach (Tile tile in tileList)
        {
            tile.AStarts();
        }

        selectedPipe = allPipes[SelectedPipeIndex];
        selectedPipe.SelectPipe();

        //Debug.Log(allPipes[3].pipeMatrixPosition);
        Debug.Log(pipeMatrix.DefinePositionInMatrix(2,1))
    }


    void Update()
    {
        controls.BUpdates();
       
    }

    public void SelectNextTile()
    {
        selectedPipe.UnselectPipe();
        SelectedPipeIndex++;
        selectedPipe = allPipes[SelectedPipeIndex];
        selectedPipe.SelectPipe();
        Debug.Log(SelectedPipeIndex);
    }

    
}
