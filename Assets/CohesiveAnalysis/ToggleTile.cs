using UnityEngine.Tilemaps;

namespace CohesiveAnalysis
{
    public class ToggleTile
    {
        TileBase defaultTile;
        TileBase altTile;
        
        public TileBase DefaultTile => defaultTile;
        public TileBase AltTile => altTile;
        
        public bool IsDefault(TileBase tile)
        {
            return tile == defaultTile;
        }
        
        public bool IsAlt(TileBase tile)
        {
            return tile == altTile;
        }
    }
}