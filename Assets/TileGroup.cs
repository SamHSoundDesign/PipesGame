using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGroup : MonoBehaviour
{
    private int maxGridWidWidth;
    private int maxGridWidHeight;
    public List<Tile> tilesInGroup;
   

    public TileGroup()
    {
        maxGridWidHeight = 4;
        maxGridWidWidth = 4;
}

}
