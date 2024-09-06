using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Tilemaps;

namespace CohesiveAnalysis
{
    public class SwapTileOnTriggerEnter : MonoBehaviour
    {
        [SerializeField] Tilemap tilemap;
        
        ToggleTile toggle;
        readonly Movement playerMovement = new();

        void OnTriggerStay2D(Collider2D collision)
        {
            askldjfkl(collision);
            if (playerMovement.HasMoved)
                SwapTiles();
        }

        void askldjfkl(Collider2D collision)
        {
            playerMovement.Update(PlayerTilePos(collision.transform.position));
        }

        Vector3Int PlayerTilePos(Vector3 transformPosition)
        {
            return tilemap.WorldToCell(transformPosition);
        }

        void SwapTiles()
        {
            RevertirElTileAnterior();
            CambiarElTileActual();
        }

        void CambiarElTileActual()
        {
            if (toggle.IsDefault(CurrentTile()))
            {
                SwapToAlt();
            }
        }

        void SwapToAlt()
        {
            tilemap.SetTile(playerMovement.Destiny, toggle.AltTile);
        }

        TileBase CurrentTile()
        {
            return tilemap.GetTile(playerMovement.Destiny);
        }

        void RevertirElTileAnterior()
        {
            tilemap.SetTile(playerMovement.Origin, toggle.DefaultTile);
        }
    }
}