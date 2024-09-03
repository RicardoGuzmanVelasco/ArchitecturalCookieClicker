using UnityEngine;
using UnityEngine.Tilemaps;

namespace CohesiveAnalysis
{
    public class SwapTileOnTriggerEnter : MonoBehaviour
    {
        [SerializeField]
        private Tilemap tilemap;
        [SerializeField]
        private TileBase defaultTile;
        [SerializeField]
        private TileBase swapTile;

        private Vector3Int previousTilePosition;

        private Vector3 playerWorldPos;
        private Vector3Int playerTilePos;
        
        private void Awake()
        {
            if (tilemap == null)
            {
                tilemap = GetComponent<Tilemap>();
            }
        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            if (tilemap == null) return;

            playerWorldPos = collision.transform.position;

            playerTilePos = tilemap.WorldToCell(playerWorldPos);

            if (playerTilePos != previousTilePosition)
            {
                // Revertir el tile anterior
                if (tilemap.GetTile(previousTilePosition) == swapTile)
                {
                    tilemap.SetTile(previousTilePosition, defaultTile);
                }

                // Cambiar el tile actual
                TileBase currentTile = tilemap.GetTile(playerTilePos);
                if (currentTile == defaultTile)
                {
                    tilemap.SetTile(playerTilePos, swapTile);
                }

                // Actualizar la posici�n del tile anterior
                previousTilePosition = playerTilePos;
            }
        }
    }
}