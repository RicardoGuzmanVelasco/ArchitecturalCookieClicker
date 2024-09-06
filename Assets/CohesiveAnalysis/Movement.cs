using UnityEngine;

namespace CohesiveAnalysis
{
    class Movement
    {
        Vector3Int previous;
        Vector3Int current;
        
        public bool HasMoved => current != previous;

        public Vector3Int Origin => previous;
        public Vector3Int Destiny => current;

        public void Update(Vector3Int newPosition)
        {
            previous = current;
            current = newPosition;
        }
    }
}