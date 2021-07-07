public class GridController : Controllers
{
    private int xWidth;
    private int unitsPerGrid;
    private int[,] grid;

public GridController(GameController gameController , int xWidth , int unitsPerGrid)
    {
        this.gameController = gameController;
        this.xWidth = xWidth;
        this.unitsPerGrid = unitsPerGrid;

        
    }
   

    public void AddGameBoardObjectToGrid(GameBoardObjects gameBoardObject , int GameBoardObjectID)
    {

    }

    public int[] ConvertTileIdTo2DArray(int tileIndex)
    {
        int[] intArray = new int[2];

        int column = tileIndex / xWidth;
        int row = 0;

        for (int i = 0; i < xWidth; i++)
        {
            if (tileIndex % xWidth == i)
            {
                row = i;
            }
        }

        intArray[0] = row;
        intArray[1] = column;
           
        


        return intArray;
    }
}
