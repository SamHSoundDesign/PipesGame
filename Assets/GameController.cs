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

    private int selectedTileIndex;
    private Tile selectedTile;

    public GameController()
    {
        selectedTileIndex = 0;
    }

    void Start()
    {
        gameController = GetComponent<GameController>();
        controls = GetComponent<Controls>();
        Controls.gameController = this.gameController;
        Tile.gameController = this.gameController;

        tileList = tileGroup.tilesInGroup;

        foreach (Tile tile in tileList)
        {
            tile.AStarts();

            selectedTile = tileList[selectedTileIndex];
        }
    }


    void Update()
    {
        controls.BUpdates();
    }

    public void SelectNextTile()
    {
        selectedTile = tileList[selectedTileIndex];
        selectedTile.UnselectTile();
        selectedTileIndex++;
        selectedTile = tileList[selectedTileIndex];
        selectedTile.SelectTile();
    }

    
}
